using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashCode.QualificationRound._2019
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void GetPhotos_ReadCorrectNumberOfPhotos()
        {
            // Arrange
            var input = @"input\a_example.txt";

            // Act
            var result = Solution.GetPhotos(input);

            // Assert
            result.Length.Should().Be(4);
        }

        [TestMethod]
        public void GetPhoto_ReadCorrectTags()
        {
            // Arrange
            var input = @"input\a_example.txt";

            // Act
            var result = Solution.GetPhotos(input);

            // Assert
            result.Length.Should().Be(4);
            result[0][0].Should().Be("H");
            result[0][1].Should().Be("3");
            result[0][2].Should().Be("cat");
            result[0][3].Should().Be("beach");
            result[0][4].Should().Be("sun");
        }

        [TestMethod]
        public void EvaluateTransactionInterestFactor_ReturnCorrectValue()
        {
            // Arrange
            var slideOrigin = new []{ "garden", "cat" };
            var slideDestination = new []{"garden","selfie","smile"};

            // Act
            var result = Solution.EvaluateTransactionInterestFactor(slideOrigin, slideDestination);

            // Assert
            result.Should().Be(1);
        }
    }
}
