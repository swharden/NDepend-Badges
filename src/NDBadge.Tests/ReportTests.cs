using NUnit.Framework;
using System.IO;
using System;

namespace NDBadge.Tests
{
    public class Tests
    {
        static string REPORT_PATH = Path.GetFullPath(Path.Combine(TestContext.CurrentContext.TestDirectory, "../../../../../reports/NDependTrendData2021.xml"));

        [Test]
        public void Test_ReportFile_Exists()
        {
            Assert.That(File.Exists(REPORT_PATH), REPORT_PATH);
        }

        [Test]
        public void Test_ReportFile_CanBeRead()
        {
            var report = new Report(REPORT_PATH);
            Assert.IsNotEmpty(report.Metrics);
            Assert.IsNotEmpty(report.LatestMetrics);
            Assert.AreEqual(64, report.LatestMetrics.Length);

            foreach (var metric in report.Metrics)
                Console.WriteLine(metric);
        }

        [Test]
        public void Test_ReportFile_MakeLatestBadges()
        {
            string outputFolder = Path.GetFullPath("latest-badges");
            if (Directory.Exists(outputFolder))
                Directory.Delete(outputFolder, true);
            Directory.CreateDirectory(outputFolder);

            var report = new Report(REPORT_PATH);
            report.MakeBadges(report.LatestMetrics, outputFolder);
        }
    }
}