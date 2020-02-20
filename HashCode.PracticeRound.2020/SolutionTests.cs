using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashCode.PracticeRound._2020
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void ParseInputFile_ReadInputDataCorrectly()
        {
            // Arrange
            var expected = new Input
            {
                MaxSlicesToOrder = 17,
                NumberOfDifferentTypeOfPizza = 4,
                NumberOfSlices = new []{ 2, 5, 6, 8 },
            };

            //Act
            var result = Input.ParseInputFile(@"input\a_example.in");

            //Assert
            result.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void ParseOutputFile_ReadDataCorrectly()
        {
            // Arrange
            var expected = new Output()
            {
                TypeOfPizzas = 3,
                OrderingPizzas = new[] { 0, 2, 3 },
            };

            //Act
            var result = Output.ParseFile(@"output\a_example.out");

            //Assert
            result.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        [Ignore]
        public void ProcessExample_ProvideCorrectResult()
        {
            // Arrange
            var input = new Input
            {
                MaxSlicesToOrder = 17,
                NumberOfDifferentTypeOfPizza = 4,
                NumberOfSlices = new[] { 2, 5, 6, 8 },
            };

            // Act
            var result = Solution.Process1(input);
            Console.WriteLine($"The number of pizzas ordered is {result.TypeOfPizzas}");

            // Assert
            result.TypeOfPizzas.Should().BeLessOrEqualTo(input.MaxSlicesToOrder);
        }

        [TestMethod]
        public void ExportOutput_CreateFiles()
        {
            // Arrange
            var output = new Output()
            {
                TypeOfPizzas = 3,
                OrderingPizzas = new[] { 0,2,3},
            };

            var outputPath = @"output\a_example.out";
            
            // Act
            output.ExportToFile(outputPath);

            // Assert
            File.Exists(outputPath).Should().BeTrue();
        }

        [TestMethod]
        [Ignore]
        public void ProcessWithSolution1()
        {
            // Arrange
            var filesToProcess = new[]
            {
                "a_example",
                "b_small",
                "c_medium",
                "d_quite_big",
                "e_also_big",
            };

            Func<Input, Output> solutionToUse = Solution.Process1;

            // Act
            var finalScore = Process(filesToProcess, solutionToUse);

            // Assert
            finalScore.Should().Be(1504990057);
        }

        [TestMethod]
        [Ignore]
        public void ProcessWithSolution2()
        {
            // Arrange
            var filesToProcess = new[]
            {
                "a_example",
                "b_small",
                "c_medium",
                "d_quite_big",
                "e_also_big",
            };

            Func<Input, Output> solutionToUse = Solution.Process2;

            // Act
            var finalScore = Process(filesToProcess, solutionToUse);

            // Assert
            finalScore.Should().Be(1505004318);
        }

        private int Process(string[] filesToProcess, Func<Input, Output> solutionToUse)
        {
            var finalScore = 0;
            foreach (var file in filesToProcess)
            {
                var input = Input.ParseInputFile($"input\\{file}.in");
                var result = solutionToUse(input);
                result.ExportToFile($"output\\{file}.out");

                for (var pizza = 0; pizza < result.TypeOfPizzas; pizza++)
                {
                    finalScore += input.NumberOfSlices[result.OrderingPizzas[pizza]];
                }
            }

            Console.WriteLine($"The score is {finalScore}");

            return finalScore;
        }
    }
}
