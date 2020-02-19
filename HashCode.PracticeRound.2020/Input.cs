using System;
using System.IO;
using System.Linq;

namespace HashCode.PracticeRound._2020
{
    public class Input
    {
        public int MaxSlicesToOrder { get; set; }

        public int NumberOfDifferentTypeOfPizza { get; set; }

        public int[] NumberOfSlices { get; set; }

        public static Input ParseInputFile(string path)
        {
            using var reader = new StreamReader(path);

            var result = new Input();

            var header = reader.ReadLine().Split(" ");
            
            result.MaxSlicesToOrder = Int32.Parse(header.First());

            result.NumberOfDifferentTypeOfPizza = Int32.Parse(header.Last());

            result.NumberOfSlices = reader.ReadLine().Split(" ").Select(Int32.Parse).ToArray();

            return result;
        }
    }
}