using System.Collections.Generic;
using NUnit.Framework;
using FindMyPastTechTest.BusinessLogic; 

namespace FindMyPastTechTest.Tests.Tests
{
    [TestFixture]
    class NumberGeneration
    {
        [Test]
        public void Generate_Prime_Number()
        {
            List<int> expected = new List<int>() { 2 };
            var primeList = PrimeNumberListGenerator.Generate(1);

            Assert.AreEqual(expected[0], primeList[0]);
                }

        [Test]
        public void Generate_Prime_Numbers()
        {
            List<int> expected = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113,	127 };
            var primeList = PrimeNumberListGenerator.Generate(31);
            
            Assert.AreEqual(expected[0], primeList[0]);
            Assert.AreEqual(expected[10], primeList[10]);
            Assert.AreEqual(expected[20], primeList[20]);
            Assert.AreEqual(expected[30], primeList[30]);
        }
    }
}
