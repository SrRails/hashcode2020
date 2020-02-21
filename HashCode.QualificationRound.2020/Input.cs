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
        public List<Library> Libraries { get; set; } = new List<Library>();
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

            //result.Libraries = new List<Library>(result.LibrariesQty);
            
            for (int library = 0; library <= result.LibrariesQty - 1; library++)
            {
                header = reader.ReadLine().Split(" ").ToList();

                var tempLibrary = new Library();

                tempLibrary.Id = library;
                tempLibrary.BooksQty = Int32.Parse(header[0]);
                tempLibrary.DaysToSign = Int32.Parse(header[1]);
                tempLibrary.BookPerDay = Int32.Parse(header[2]);
                
                var books = reader.ReadLine().Split(" ").Select(Int32.Parse).ToList();

                for (int bookIndex = 0; bookIndex < books.Count; bookIndex++)
                {
                    var bookId = books[bookIndex];
                    var bookScore = result.Catalog[bookId].Score;
                   

                    tempLibrary.Books.Add(
                        new Book()
                        {
                            Id = bookId,
                            Score = bookScore
                        });
                    tempLibrary.Rank += bookScore;
                }

                tempLibrary.Rank = (tempLibrary.Rank * tempLibrary.BookPerDay)/(double)(tempLibrary.DaysToSign);
                tempLibrary.Books = tempLibrary.Books.OrderByDescending(x=>x.Score).ToList();
                result.Libraries.Add(tempLibrary);
            }

            result.Libraries = result.Libraries.OrderByDescending(x => x.Rank).ToList();
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