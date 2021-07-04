using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TakumiUtilities;

namespace TakumiUtilitiesTest
{
    [TestClass]
    public class UtilFIleTest
    {
        [TestMethod]
        public void �J�����g�f�B���N�g���Ƀt�H���_�쐬()
        {
            UtilFiles.CreateDirectoryInCurrentDirectory("temp");
            var isTruePtn = System.IO.Directory.Exists(Path.Combine(System.Environment.CurrentDirectory, "temp"));
            Assert.AreEqual(true,isTruePtn);
        }
        [TestMethod]
        public void �t���p�X�w��Ńt�H���_�쐬()
        {
            UtilFiles.CreateDirectoryByFullPath(@"C:\Users\xiaot\Documents\TEST");
            var isTruePtn = System.IO.Directory.Exists(@"C:\Users\xiaot\Documents\TEST");
            Assert.AreEqual(true, isTruePtn);
        }
        [TestMethod]
        public void �t�@�C���쐬()
        {
            var directoryPath = Path.Combine(System.Environment.CurrentDirectory, "temp");
            UtilFiles.CreateFileIfDirectoryExist(directoryPath,"test");
            var filePath = Path.Combine(directoryPath, "test");
            var isTruePtn = System.IO.File.Exists(filePath);
            Assert.AreEqual(true, isTruePtn);
        }
    }
}
