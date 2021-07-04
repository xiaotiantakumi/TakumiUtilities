using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TakumiUtilities;

namespace TakumiUtilitiesTest
{
    [TestClass]
    public class UtilFIleTest
    {
        [TestMethod]
        public void カレントディレクトリにフォルダ作成()
        {
            UtilFiles.CreateDirectoryInCurrentDirectory("temp");
            var isTruePtn = System.IO.Directory.Exists(Path.Combine(System.Environment.CurrentDirectory, "temp"));
            Assert.AreEqual(true,isTruePtn);
        }
        [TestMethod]
        public void フルパス指定でフォルダ作成()
        {
            UtilFiles.CreateDirectoryByFullPath(@"C:\Users\xiaot\Documents\TEST");
            var isTruePtn = System.IO.Directory.Exists(@"C:\Users\xiaot\Documents\TEST");
            Assert.AreEqual(true, isTruePtn);
        }
        [TestMethod]
        public void ファイル作成()
        {
            var directoryPath = Path.Combine(System.Environment.CurrentDirectory, "temp");
            UtilFiles.CreateFileIfDirectoryExist(directoryPath,"test");
            var filePath = Path.Combine(directoryPath, "test");
            var isTruePtn = System.IO.File.Exists(filePath);
            Assert.AreEqual(true, isTruePtn);
        }
    }
}
