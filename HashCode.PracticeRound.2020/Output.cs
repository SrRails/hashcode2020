using System;
using System.IO;
using System.Linq;

namespace HashCode.PracticeRound._2020
{
    public class Output
    {
        public int TypeOfPizzas { get; set; }
        public int[] OrderingPizzas { get; set; }

        public void ExportToFile(string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            using StreamWriter file = new StreamWriter(path);

            file.WriteLine(this.TypeOfPizzas);

            for(var pizza=0;pizza < this.TypeOfPizzas;pizza++)
            {
                file.Write(this.OrderingPizzas[pizza]);
                file.Write(" ");
            }
            file.Write("\n");
        }

        public static Output ParseFile(string path)
        {
            using var reader = new StreamReader(path);

            return new Output
            {
                TypeOfPizzas = Int32.Parse(reader.ReadLine()),
                OrderingPizzas = reader.ReadLine().Split(" ").SkipLast(1).Select(Int32.Parse).ToArray()
            };
        }
    }
}