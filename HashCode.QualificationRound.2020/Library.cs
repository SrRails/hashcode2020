using System;
using System.Collections.Generic;

namespace HashCode.QualificationRound._2020
{
    public class Library
    {
        public int DaysToSign { get; set; }
        public int BookPerDay { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        public int Id { get; set; }
        public int BooksQty { get; set; }
        public double Rank { get; set; } = 0;
    }
}