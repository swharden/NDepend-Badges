using NUnit.Framework;
using System.IO;
using System;

namespace NDBadge.Tests
{
    public class Tests
    {
        public static string REPORT_PATH = Path.GetFullPath(Path.Combine(TestContext.CurrentContext.TestDirectory, "../../../../../reports/NDependTrendData2021.xml"));

        [Test]
        public void Test_ReportFile_Exists()
        {
            Assert.That(File.Exists(REPORT_PATH), REPORT_PATH);
        }
    }
}