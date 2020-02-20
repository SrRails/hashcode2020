using System;
using System.IO;
using System.Linq;

namespace HashCode.QualificationRound._2020
{
    public class Input
    {
        public int BooksQty { get; set; }
        public int LibrariesQty { get; set; }
        public Library[] Libraries { get; set; }
        public int[] Catalog { get; set; }
        public int DaysForScanning { get; set; }
        public static Input ParseInputFile(string path)
        {
            using var reader = new StreamReader(path);
            var result = new Input();
            var header = reader.ReadLine().Split(" ").ToList();

            result.BooksQty = Int32.Parse(header[0]);
            result.LibrariesQty = Int32.Parse(header[1]);
            result.DaysForScanning = Int32.Parse(header[2]);

            result.Catalog = new int[result.BooksQty];
            result.Catalog = reader.ReadLine().Split(" ").Select(Int32.Parse).ToArray();

            result.Libraries = new Library[result.LibrariesQty];

            for (int i = 0; i <= result.LibrariesQty - 1; i++)
            {
                header = reader.ReadLine().Split(" ").ToList();

                result.Libraries[i] = new Library();
                result.Libraries[i].Id = i;
                result.Libraries[i].BooksQty = Int32.Parse(header[0]);
                result.Libraries[i].DaysToSign = Int32.Parse(header[1]);
                result.Libraries[i].BookPerDay = Int32.Parse(header[2]);

                result.Libraries[i].Books = reader.ReadLine().Split(" ").Select(Int32.Parse).ToArray();
            }
            return result;
        }
    }
}