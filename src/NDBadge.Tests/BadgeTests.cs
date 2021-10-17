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
        public void Test_Badge_Save()
        {
            string filePath = System.IO.Path.GetFullPath("save.png");
            var badge = new Badge("Tests", "1234")
            {
                BackgroundRight = Microsoft.Maui.Graphics.Color.FromArgb("#3cc51d"),
            };

            badge.SavePng(filePath, 1);
            Console.WriteLine(filePath);
        }
    }
}
