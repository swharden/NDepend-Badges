using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDBadge.Tests
{
    internal class BadgeTests
    {
        [Test]
        public void Test_Badge_PNG()
        {
            string filePath = System.IO.Path.GetFullPath("save.png");
            var badge = new Badge("Tests", "1234");
            badge.SavePng(filePath, 1);
            Console.WriteLine(filePath);
        }

        [Test]
        public void Test_Badge_SVG()
        {
            string filePath = System.IO.Path.GetFullPath("save.svg");
            var badge = new Badge("Average # Lines of Code for Methods with at least 3 Lines of Code", "10.345");
            badge.SaveSVG(filePath);
            Console.WriteLine(filePath);
        }
    }
}