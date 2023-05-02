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

    }
}
