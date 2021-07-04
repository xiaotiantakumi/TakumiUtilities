using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TakumiUtilities;

namespace TakumiUtilitiesTest
{
    [TestClass]
    public class CsvTest
    {
        private readonly string _directoryPath = Path.Combine(System.Environment.CurrentDirectory, "temp");
        private readonly string _filePath = Path.Combine(System.Environment.CurrentDirectory, "temp", "test.csv");

        [TestMethod]
        public void CreateCsvFile()
        {
            using (var stream = File.CreateText(_filePath))
            {
                stream.WriteLine(string.Join(",", new List<string>(){"col1","col2","col3"}));
                var r = new Random();
                for (int i = 0; i < 100; i++)
                {
                    stream.WriteLine(string.Join(",", new List<string>()
                    {
                        r.Next(1000).ToString(), r.Next(1000).ToString(), r.Next(1000).ToString()
                    }));
                }
            }
        }
        [TestMethod]
        public void ReadCsvFile()
        {
            var filePath = Path.Combine(System.Environment.CurrentDirectory, "temp", "test.csv");
        }
        
    }
}
