using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashCode.QualificationRound._2020
{
    public class Library
    {
        public int DaysToSign { get; set; }

        public int BookPerDay { get; set; }

        public int[] Books { get; set; }

        public int Id { get; set; }
    }

    public class Input
    {
        public Library[] Libraries { get; set; }

        public int[] Catalog { get; set; }

        public int DaysForScanning { get; set; }
    }

    public class Output
    {
        public int NumberOfLibraries { get; set; }

        public Library[] Libraries { get; set; }

        public void WriteOutput(string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            using StreamWriter file = new StreamWriter(path);

            file.WriteLine(this.Libraries.Length);

            foreach (var library in this.Libraries)
            {
                file.Write(library.Id);
                file.Write(" ");
                file.Write(library.Books.Length);
                file.Write("\n");

                foreach (var book in library.Books)
                {
                    file.Write(book);
                    file.Write(" ");
                }
                file.Write("\n");
            }
            file.Write("\n");
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var input = new Input()
            {
                Libraries = new Library[]
                {
                    new Library()
                    {
                        DaysToSign = 0,
                    },
                    new Library()
                        { },
                }
            };


        }

        [TestMethod]
        public void TestParseOutput()
        {
            var library1 = new Library()
            {
                Id = 1,
                Books = new int[] { 5,2,3},
            };
            var library2 = new Library()
            {
                Id = 0,
                Books = new int[] { 0, 1, 2, 3, 4 },
            };
            
            var output = new Output()
            {
                Libraries = new Library[]{library1, library2},
            };

            output.WriteOutput(@"output\example.txt");
        }
    }
}
