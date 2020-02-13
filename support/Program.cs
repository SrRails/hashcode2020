using System;
using System.IO;
using System.Text;

namespace hascode2020
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("pamelachuunkitopo...");
            var filePath="fileForTest.txt";
            Console.WriteLine(ReadFile(filePath));
            Environment.Exit(0);
        }

        private static string ReadFile(string filePath)
        {
            StringBuilder stringBuilder=new StringBuilder();
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                string content=reader.ReadToEnd();
                stringBuilder.Append(content);
            }
            return stringBuilder.ToString();
        }

    }
}