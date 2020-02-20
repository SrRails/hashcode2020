using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashCode.QualificationRound._2020
{
    public class Library
    {
        public int DaysToSign { get; set; }

        public int BookPerDay { get; set; }

        public int[] Books { get; set; }
    }

    public class Input
    {
        public Library[] Libraries { get; set; }

        public int[] Catalog { get; set; }

        public int DaysForScanning { get; set; }
    }

    public class Output
    {
        public int NumberOfLibraries { get; set; }

        public Library[] Libraries { get; set; }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
