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

        [TestMethod]
        public void TestReadFile()
        {
            var result = Input.ParseInputFile(@"input\a_example.txt");

            result.Should().NotBeNull();

        }
        private static Output GetExampleOutput()
        {
            var library1 = new Library()
            {
                Id = 1,
                Books = new List<int>() { 5, 2, 3 },
            };
            var library2 = new Library()
            {
                Id = 0,
                Books = new List<int>() { 0, 1, 2, 3, 4 },
            };

            return new Output()
            {
                Libraries = new List<Library> { library1, library2 },
            };
        }

        [TestMethod]
        public void CalculateSolution()
        {
            var input = Input.ParseInputFile(@"input\a_example.txt");

            var result = Solution.Process(input);

            //GetExampleOutput().Should().BeEquivalentTo(result);

            result.WriteOutput(@"output\a_example.out");
        }

        [TestMethod]
        public void CalculateSolutionb()
        {
            var input = Input.ParseInputFile(@"input\b_read_on.txt");

            var result = Solution.Process(input);

            result.WriteOutput(@"output\b_read_on.out");
        }

        [TestMethod]
        public void CalculateSolutionC()
        {
            var input = Input.ParseInputFile(@"input\c_incunabula.txt");

            var result = Solution.Process(input);

            result.WriteOutput(@"output\c_incunabula.out");
        }

        [TestMethod]
        public void CalculateSolutionD()
        {
            var input = Input.ParseInputFile(@"input\d_tough_choices.txt");

            var result = Solution.Process(input);

            result.WriteOutput(@"output\d_tough_choices.out");
        }

        [TestMethod]
        public void CalculateSolutionE()
        {
            var input = Input.ParseInputFile(@"input\e_so_many_books.txt");

            var result = Solution.Process(input);

            result.WriteOutput(@"output\e_so_many_books.out");
        }

        [TestMethod]
        public void CalculateSolutionF()
        {
            var input = Input.ParseInputFile(@"input\f_libraries_of_the_world.txt");

            var result = Solution.Process(input);

            result.WriteOutput(@"output\f_libraries_of_the_world.out");
        }
    }
}
