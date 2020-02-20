using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HashCode.QualificationRound._2020
{
    public class Input
    {
        public int BooksQty { get; set; }
        public int LibrariesQty { get; set; }
        public Library[] Libraries { get; set; }
        public List<Book> Catalog { get; set; } = new List<Book>();
        public int DaysForScanning { get; set; }
        public static Input ParseInputFile(string path)
        {
            using var reader = new StreamReader(path);
            var result = new Input();
            var header = reader.ReadLine().Split(" ").ToList();

            result.BooksQty = Int32.Parse(header[0]);
            result.LibrariesQty = Int32.Parse(header[1]);
            result.DaysForScanning = Int32.Parse(header[2]);


            var tempCatalog = reader.ReadLine().Split(" ").Select(Int32.Parse).ToArray();

            for (int i = 0; i < tempCatalog.Length-1; i++)
            {
                result.Catalog.Add(new Book() { Id =i, Score = tempCatalog[i]});
            }

            result.Libraries = new Library[result.LibrariesQty];

            for (int i = 0; i <= result.LibrariesQty - 1; i++)
            {
                header = reader.ReadLine().Split(" ").ToList();

                result.Libraries[i] = new Library();
                result.Libraries[i].Id = i;
                result.Libraries[i].BooksQty = Int32.Parse(header[0]);
                result.Libraries[i].DaysToSign = Int32.Parse(header[1]);
                result.Libraries[i].BookPerDay = Int32.Parse(header[2]);

                result.Libraries[i].Books = reader.ReadLine().Split(" ").Select(Int32.Parse).ToList();
            }
            return result;
        }
    }

    public class Book
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public bool Scanned { get; set; } = false;
    }
}