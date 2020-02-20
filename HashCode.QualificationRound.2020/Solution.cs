using System;
using System.Data.Common;

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

                    Int64 maxBooksScan = dayForScanning * library.BookPerDay;
                    var scanned=0;

                    var index = 0;

                    while (index < library.BooksQty-1 && scanned < maxBooksScan)
                    {
                        if (!input.Catalog[library.Books[index].Id].Scanned)
                        {
                            newLibrary.Books.Add(library.Books[index]);
                            input.Catalog[library.Books[index].Id].Scanned = true;
                            scanned++;
                        }

                        index++;
                    }

                    newLibrary.BooksQty = newLibrary.Books.Count;

                    newLibrary.BookPerDay = library.BookPerDay;
                    newLibrary.DaysToSign = library.DaysToSign;

                    if (newLibrary.Books.Count > 0)
                    { 
                        result.Libraries.Add(newLibrary);
                    }
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