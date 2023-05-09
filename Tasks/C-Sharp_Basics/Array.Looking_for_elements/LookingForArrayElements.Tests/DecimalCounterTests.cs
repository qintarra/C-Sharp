using NUnit.Framework;

namespace LookingForArrayElements.Tests
{
    [TestFixture]
    public sealed class DecimalCounterTests
    {
        private static readonly decimal[] ArrayWithFiveElements = { 0.1m, 0.2m, 0.3m, 0.4m, 0.5m };
        private static readonly decimal[] ArrayWithFifteenElements = { decimal.MaxValue, -0.1m, -0.2m, decimal.One, -0.3m, -0.4m, -0.5m, decimal.Zero, 0.1m, 0.2m, 0.3m, 0.4m, 0.5m, decimal.MinusOne, decimal.MinValue };

        [Test]
        public void DecimalCounter_ArrayToSearchIsNull_ThrowArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(
                () => DecimalCounter.GetDecimalsCount(null, Array.Empty<decimal[]>()),
                message: "Method throws ArgumentNullException in case array to search is null.");
        }

        [Test]
        public void DecimalCounter_ArrayOfRangesIsNull_ThrowArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(
                () => DecimalCounter.GetDecimalsCount(Array.Empty<decimal>(), null),
                message: "Method throws ArgumentNullException in case array of ranges is null.");
        }

        [Test]
        public void DecimalCounter_ArrayToSearchIsEmpty_ReturnZeroOccurrences()
        {
            // Arrange
            decimal[][] ranges =
            {
                new[] { 0.1m, 0.2m },
            };

            // Act
            int actual = DecimalCounter.GetDecimalsCount(Array.Empty<decimal>(), ranges);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void DecimalCounter_ArrayOfRangesIsEmpty_ReturnZeroOccurrences()
        {
            // Act
            int actual = DecimalCounter.GetDecimalsCount(DecimalCounterTests.ArrayWithFiveElements, Array.Empty<decimal[]>());

            // Assert
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void DecimalCounter_OneOfTheRangesIsNull_ThrowArgumentNullException()
        {
            // Arrange
            decimal[]?[] ranges =
            {
                new decimal[] { 0.1m, 0.2m },
                null,
            };

            // Act
            // Replace ArgumentNullException with ArgumentException in new task.
            Assert.Throws<ArgumentNullException>(
                () => DecimalCounter.GetDecimalsCount(Array.Empty<decimal>(), ranges),
                message: "Method throws ArgumentNullException in case one of the ranges is null.");
        }

        [Test]
        public void DecimalCounter_OneOfTheRangesIsInvalid_ThrowArgumentException()
        {
            // Arrange
            decimal[][] ranges =
            {
                new[] { 0.1m, 0.2m },
                new[] { 0.4m, 0.5m, 0.6m },
            };

            // Act
            Assert.Throws<ArgumentException>(
                () => DecimalCounter.GetDecimalsCount(Array.Empty<decimal>(), ranges),
                message: "Method throws ArgumentException in case the length of one of the ranges is less or greater than 2.");
        }

        [Test]
        public void DecimalCounterFiveElementsOneRangeReturnsResult()
        {
            // Arrange
            decimal[][] ranges =
            {
                new[] { 0.1m, 0.2m },
            };

            // Act
            int actualResult = DecimalCounter.GetDecimalsCount(DecimalCounterTests.ArrayWithFiveElements, ranges);

            // Assert
            Assert.AreEqual(2, actualResult);
        }

    }
}
