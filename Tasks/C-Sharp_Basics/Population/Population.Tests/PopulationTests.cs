using System;
using NUnit.Framework;

namespace PopulationTask.Tests
{
    [TestFixture]
    [Timeout(2_000)]
    public class PopulationTests
    {
        [TestCase(1500, 5, 100, 5000, ExpectedResult = 15)]
        [TestCase(1500000, 2.5, 10000, 2000000, ExpectedResult = 10)]
        [TestCase(1500000, 0.25, 1000, 2000000, ExpectedResult = 94)]
        public int GetYears_Return_Count_Of_Years(int initialPopulation, double percent, int visitors, int currentPopulation)
            => Population.GetYears(initialPopulation, percent, visitors, currentPopulation);

        [TestCase(0, 0.25, 1000, 2000000)]
        [TestCase(-100, 0.25, 1000, 2000000)]
        public void GetYears_InitialPopulation_LessOrEqualsZero_ThrowArgumentException(
            int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            Assert.Throws<ArgumentException>(
                () => Population.GetYears(initialPopulation, percent, visitors, currentPopulation),
                message: "Initial population cannot be less or equals zero.");
        }

    }
}
