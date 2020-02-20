using System;

namespace HashCode.QualificationRound._2020
{
    public class Solution
    {
        public static Output Process(Input input)
        {
            var result = new Output();

            //;

            var dayPassed = 0;

            for(int c=0; c < input.Libraries.Length; c++ )
            {
                var library = input.Libraries[c];

                var candidateDayPassed = dayPassed + library.DaysToSign;

                if (candidateDayPassed < input.DaysForScanning)
                {
                    //result.Libraries.
                }

            }

            return result;
        }
    }
}