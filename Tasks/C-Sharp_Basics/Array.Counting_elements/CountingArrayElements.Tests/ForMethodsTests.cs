using NUnit.Framework;

namespace CountingArrayElements.Tests
{
    [TestFixture]
    public sealed class ForMethodsTests
    {
        [Test]
        public void GetNegativeIntegerCount_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetNegativeIntegerCount(null));
        }

        [TestCase(new[] { -1, 1, -1, 2, -2, -3, 3, 4, 5, 6, -6, 0 }, ExpectedResult = 5)]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, ExpectedResult = 0)]
        [TestCase(new[] { -1, -2, -3, -4, -5, -6 }, ExpectedResult = 6)]
        [TestCase(new[] { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10, 0 }, ExpectedResult = 10)]
        public int GetNegativeIntegerCount_ParametersAreValid_ReturnsResult(int[] arrayToSearch)
        {
            // Act
            return ForMethods.GetNegativeIntegerCount(arrayToSearch);
        }

        [Test]
        public void GetNegativeIntegerCountRecursive_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetNegativeIntegerCountRecursive(null));
        }

    }
}
