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

            for (int i = 0; i <= tempCatalog.Length-1; i++)
            {
                result.Catalog.Add(new Book() { Id =i, Score = tempCatalog[i]});
            }

            result.Libraries = new Library[result.LibrariesQty];

            for (int library = 0; library <= result.LibrariesQty - 1; library++)
            {
                header = reader.ReadLine().Split(" ").ToList();

                result.Libraries[library] = new Library();
                result.Libraries[library].Id = library;
                result.Libraries[library].BooksQty = Int32.Parse(header[0]);
                result.Libraries[library].DaysToSign = Int32.Parse(header[1]);
                result.Libraries[library].BookPerDay = Int32.Parse(header[2]);

                var books = reader.ReadLine().Split(" ").Select(Int32.Parse).ToList();

                for (int bookIndex = 0; bookIndex < books.Count - 1; bookIndex++)
                {
                    var bookId = books[bookIndex];
                    var bookScore = result.Catalog[bookId].Score;

                    result.Libraries[library].Books.Add(
                        new Book()
                        {
                            Id = bookId,
                            Score = bookScore
                        });
                }

                result.Libraries[library].Books = result.Libraries[library].Books.OrderByDescending(x=>x.Score).ToList();
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