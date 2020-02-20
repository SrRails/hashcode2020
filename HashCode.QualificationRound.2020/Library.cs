using System.Collections.Generic;

namespace HashCode.QualificationRound._2020
{
    public class Library
    {
        public int DaysToSign { get; set; }
        public int BookPerDay { get; set; }
        public List<int> Books { get; set; } = new List<int>();
        public int Id { get; set; }
        public int BooksQty { get; set; }
    }
}