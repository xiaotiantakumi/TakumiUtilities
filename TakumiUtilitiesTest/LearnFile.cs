using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TakumiUtilities;

namespace TakumiUtilitiesTest
{
    [TestClass]
    public class LearnFile
    {
        [TestMethod]
        public void CreateTextの実験()
        {
            var filePath = Path.Combine(System.Environment.CurrentDirectory, "temp", "test.txt");
            using (var stream = File.CreateText(filePath))
            {
                stream.WriteLine("test1");
                stream.WriteLine("test2");
            }
        }
        [TestMethod]
        public void ファイル削除()
        {
            var filePath = Path.Combine(System.Environment.CurrentDirectory, "temp", "test.txt");
            File.Delete(filePath);
            Assert.AreEqual(false,File.Exists(filePath));
        }
        private readonly string _directoryPath = Path.Combine(System.Environment.CurrentDirectory, "temp");
        private readonly string _filePath = Path.Combine(System.Environment.CurrentDirectory, "temp", "test.csv");
        [TestMethod]
        public void Encrypt()
        {
            var exsist = File.Exists(Path.Combine(System.Environment.CurrentDirectory, "temp", "test.csv"));
            Assert.IsTrue(exsist);
            // このメソッドは、Windows のすべてのバージョンで使用できるわけではありません。 たとえば、Home edition では使用できません。
            File.Encrypt(_filePath);
        }
        [TestMethod]
        public void UpdateFilesAccessTime()
        {
            // 指定されたディレクトリ配下のファイルパスを取得する動きは一緒。
            // ただ、遅延取得か即時取得かの違いがある。
            var files = Directory.GetFiles(_directoryPath);
            var enumeratefiles = Directory.EnumerateFiles(_directoryPath);
            var updateTime = DateTime.Now;
            foreach (var file in enumeratefiles)
            {
                File.SetLastAccessTime(file, updateTime);
            }
        }
    }
}
