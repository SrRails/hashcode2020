using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashCode.QualificationRound._2020
{
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
            var output = GetExampleOutput();

            output.WriteOutput(@"output\example.txt");
        }

        private static Output GetExampleOutput()
        {
            var library1 = new Library()
            {
                Id = 1,
                Books = new int[] { 5, 2, 3 },
            };
            var library2 = new Library()
            {
                Id = 0,
                Books = new int[] { 0, 1, 2, 3, 4 },
            };

            return new Output()
            {
                Libraries = new List<Library> { library1, library2 },
            };
        }

        [TestMethod]
        public void CalculateSolution()
        {
            var input = new Input();

            var result = Solution.Process(input);

            GetExampleOutput().Should().BeEquivalentTo(result);

        }
    }
}
