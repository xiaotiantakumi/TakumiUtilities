using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TakumiUtilities
{
    public static class UtilFiles
    {
        /// <summary>
        /// 実行ファイルの元にフォルダ作成
        /// </summary>
        /// <param name="fileName">ファイル名</param>
        public static void CreateDirectoryInCurrentDirectory(string fileName)
        {
            var path= Path.Combine(System.Environment.CurrentDirectory, fileName);
            Directory.CreateDirectory(path);
        }
        /// <summary>
        /// フルパスでフォルダ作成
        /// </summary>
        /// <param name="fullPath">降るパス</param>
        public static void CreateDirectoryByFullPath(string fullPath)
        {
            Directory.CreateDirectory(fullPath);
        }

        /// <summary>
        /// ファイル作成
        /// </summary>
        /// <param name="validateDirectoryPath">フルパス</param>
        /// <param name="fileName">ファイル名</param>
        public static void CreateFileIfDirectoryExist(string validateDirectoryPath,string fileName)
        {
            var existsDirectory = Directory.Exists(validateDirectoryPath);
            if (existsDirectory)
            {
                var path = Path.Combine(validateDirectoryPath, fileName);
                var file = File.CreateText(path);
            }
        }
    }
}
