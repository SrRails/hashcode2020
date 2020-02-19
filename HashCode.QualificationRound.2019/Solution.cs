using System;
using System.IO;
using System.Linq;

namespace HashCode.QualificationRound._2019
{
    public class Solution
    {
        public static string[][] GetPhotos(string path)
        {
            using var reader = new StreamReader(path);

            var numberOfPhotos = Int32.Parse(reader.ReadLine());

            var photos = new string[numberOfPhotos][];

            for (var i = 0; i < numberOfPhotos; i++)
            {
                var line = reader.ReadLine();
                photos[i] = line.Split(" ");
            }
            return photos;
        }

        public static int EvaluateTransactionInterestFactor(string[] originTags, string[] destinationTags)
        {
            var commonTags = originTags.Intersect(destinationTags).Count();

            return new[] {
                commonTags,
                originTags.Length - commonTags,
                destinationTags.Length - commonTags}
                .Min();
        }
    }
}