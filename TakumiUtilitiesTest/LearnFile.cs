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
        public void CreateText�̎���()
        {
            var filePath = Path.Combine(System.Environment.CurrentDirectory, "temp", "test.txt");
            using (var stream = File.CreateText(filePath))
            {
                stream.WriteLine("test1");
                stream.WriteLine("test2");
            }
        }
        [TestMethod]
        public void �t�@�C���폜()
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
            // ���̃��\�b�h�́AWindows �̂��ׂẴo�[�W�����Ŏg�p�ł���킯�ł͂���܂���B ���Ƃ��΁AHome edition �ł͎g�p�ł��܂���B
            File.Encrypt(_filePath);
        }
        [TestMethod]
        public void UpdateFilesAccessTime()
        {
            // �w�肳�ꂽ�f�B���N�g���z���̃t�@�C���p�X���擾���铮���͈ꏏ�B
            // �����A�x���擾�������擾���̈Ⴂ������B
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
