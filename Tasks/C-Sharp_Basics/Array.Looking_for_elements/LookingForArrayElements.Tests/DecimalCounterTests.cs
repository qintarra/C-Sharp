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

    }
}
