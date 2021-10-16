using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace NDBadge
{
    public class Report
    {
        public readonly Metric[] Metrics;
        public Metric[] LatestMetrics
        {
            get
            {
                DateTime latestDateTime = Metrics.Select(x => x.DateTime).Distinct().OrderBy(x => x).Last();
                return Metrics.Where(x => x.DateTime == latestDateTime).ToArray();
            }
        }

        public Report(string xmlFilePath)
        {
            if (!File.Exists(xmlFilePath))
                throw new FileNotFoundException($"File does not exist: {xmlFilePath}");

            XDocument doc = XDocument.Load(xmlFilePath);
            List<Metric> baseMetrics = new();
            foreach (var el in doc.XPathSelectElement("/Root/MetricIndex").Elements())
            {
                string name = el.Attribute("Name").Value;
                string unit = el.Attribute("Unit").Value;
                baseMetrics.Add(new Metric() { Name = name, Unit = unit });
            }

            List<Metric> allMetrics = new();
            foreach (var runElement in doc.XPathSelectElement("/Root/M").Elements())
            {
                DateTime runDateTime = DateTime.Parse(runElement.Attribute("D").Value);
                string[] values = runElement.Attribute("V").Value.Split("|");
                if (values.Length != baseMetrics.Count)
                    throw new InvalidOperationException("mismatch count mismatch");

                List<Metric> runMetrics = new();
                for (int i = 0; i < baseMetrics.Count; i++)
                    runMetrics.Add(baseMetrics[i] with { DateTime = runDateTime, Value = values[i] });

                allMetrics.AddRange(runMetrics);
            }

            Metrics = allMetrics.ToArray();
        }
    }
}
