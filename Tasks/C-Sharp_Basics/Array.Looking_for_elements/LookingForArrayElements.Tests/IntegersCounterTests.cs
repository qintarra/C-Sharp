using System;
using NUnit.Framework;

namespace LookingForArrayElements.Tests
{
    [TestFixture]
    public sealed class IntegersCounterTests
    {
        [Test]
        public void GetIntegersCount_ArrayToSearchIsNull_ThrowArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(
                () => IntegersCounter.GetIntegersCount(null, Array.Empty<int>()),
                message: "Method throws ArgumentNullException in case an array to search is null.");
        }

        [Test]
        public void GetIntegersCount_ElementsToSearchForIsNull_ThrowArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(
                () => IntegersCounter.GetIntegersCount(Array.Empty<int>(), null),
                message: "Method throws ArgumentNullException in case an array of elements to for search is null.");
        }

        [Test]
        public void GetIntegersCount_ArrayToSearchIsEmpty_ReturnZeroOccurrences()
        {
            // Arrange
            int[] elementsToSearchFor = { 2, 5, 8 };

            // Act
            int actual = IntegersCounter.GetIntegersCount(Array.Empty<int>(), elementsToSearchFor);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void GetIntegersCount_ElementsToSearchForIsEmpty_ReturnZeroOccurrences()
        {
            // Arrange
            int[] arrayToSearch = { 2, 5, 8 };

            // Act
            int actual = IntegersCounter.GetIntegersCount(arrayToSearch, Array.Empty<int>());

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 2, 5, 8 }, ExpectedResult = 3)]
        [TestCase(new[] { 1, 2, 3, 2, 4, 5, 6, 5, 5, 8, 7, 8, 9 }, new[] { 2, 5, 8 }, ExpectedResult = 7)]
        [TestCase(new[] { 1, 2, 3, 2, 4, 5, 6, 5, 5, 8, 7, 8, 9 }, new[] { -2, -5, -8 }, ExpectedResult = 0)]
        [TestCase(new[] { 5, 4, 21, 38, 25, int.MaxValue, 48, 98, 14, 43, 11, 6, 81, 532, 58 }, new[] { int.MaxValue, 47, 14, 6, 532, int.MinValue }, ExpectedResult = 4)]
        [TestCase(new[] { -5, 4, -21, 38, -25, int.MinValue, 48, -98, 14, -43, 11, -6, 81, -532, -58 }, new[] { int.MaxValue, -47, 14, -6, 532, int.MinValue }, ExpectedResult = 3)]
        public int GetIntegersCount_ParametersAreValid_ReturnsResult(int[] arrayToSearch, int[] elementsToSearchFor)
        {
            // Act
            return IntegersCounter.GetIntegersCount(arrayToSearch, elementsToSearchFor);
        }

        [Test]
        public void GetIntegersCountWithStartIndexAndCount_ArrayToSearchIsNull_ThrowArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(
                () => IntegersCounter.GetIntegersCount(null, Array.Empty<int>(), 0, 1),
                message: "Method throws ArgumentNullException in case an array to search is null.");
        }

        [Test]
        public void GetIntegersCountWithStartIndexAndCount_ElementsToSearchForIsNull_ThrowArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(
                () => IntegersCounter.GetIntegersCount(Array.Empty<int>(), null, 0, 1),
                message: "Method throws ArgumentNullException in case an array of elements to for search is null.");
        }

    }
}
