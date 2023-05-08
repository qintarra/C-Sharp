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

    }
}
