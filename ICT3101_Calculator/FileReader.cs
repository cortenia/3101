using System;
using System.IO;

namespace ICT3101_Calculator
{
    public class FileReader : IFileReader
    {
        private string dirpath = Path.Combine(Environment.CurrentDirectory, @"../../../");
        public FileReader()
        {
        }

        public string[] Read(string path)
        {
            return File.ReadAllLines(dirpath + path);
        }
    }
}