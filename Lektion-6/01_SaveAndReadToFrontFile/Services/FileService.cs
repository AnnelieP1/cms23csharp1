using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SaveAndReadToFrontFile.Services
{
    internal class FileService
    {
        private static readonly string filePath = @"C:\Users\gydan\OneDrive\Skrivbord\customers.json";
        public static void SaveToFile(string contentAsJson)
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(contentAsJson);
        }
        public static string ReadFromFile()
        {
            if (File.Exists(filePath))
            {
                using var sr = new StreamReader(filePath);
                return sr.ReadToEnd();
            }

            return null!;



        }
    }
}