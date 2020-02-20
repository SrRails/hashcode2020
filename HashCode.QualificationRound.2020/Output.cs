using System.Collections.Generic;
using System.IO;

namespace HashCode.QualificationRound._2020
{
    public class Output
    {
        public int NumberOfLibraries { get; set; }

        public List<Library> Libraries { get; set; } = new List<Library>();

        public void WriteOutput(string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            using StreamWriter file = new StreamWriter(path);

            file.WriteLine(this.Libraries.Count);

            foreach (var library in this.Libraries)
            {
                file.Write(library.Id);
                file.Write(" ");
                file.Write(library.Books.Count);
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
}