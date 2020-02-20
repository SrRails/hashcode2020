using System.IO;

namespace HashCode.QualificationRound._2020
{
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
}