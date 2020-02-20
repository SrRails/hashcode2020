using System;

namespace HashCode.QualificationRound._2020
{
    public class Solution
    {
        public static Output Process(Input input)
        {
            var result = new Output();

            var dayPassed = 0;

            for(int c=0; c < input.Libraries.Length; c++ )
            {
                var library = input.Libraries[c];

                var candidateDayPassed = dayPassed + library.DaysToSign;

                if (candidateDayPassed < input.DaysForScanning) // to check
                {
                    dayPassed = candidateDayPassed;
                    var newLibrary = new Library {Id = library.Id};

                    Int64 dayForScanning = input.DaysForScanning - dayPassed;

                    Int64 bookScanned = dayForScanning * library.BookPerDay;

                    for (var index = 0; index < bookScanned && index < library.BooksQty; index++)
                    {
                        newLibrary.Books.Add(library.Books[index]);
                    }

                    newLibrary.BooksQty = newLibrary.Books.Count;

                    newLibrary.BookPerDay = library.BookPerDay;
                    newLibrary.DaysToSign = library.DaysToSign;

                    result.Libraries.Add(newLibrary);
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}