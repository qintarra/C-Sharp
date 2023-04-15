using NUnit.Framework;

namespace CountingArrayElements.Tests
{
    [TestFixture]
    public sealed class DoWhileMethodsTests
    {
        private static readonly object[][] GetZeroDecimalCountData =
        {
            new object[] { new[] { 1.1m }, 0 },
            new object[] { new[] { decimal.Zero }, 1 },
            new object[] { new[] { decimal.Zero, 1.1m }, 1 },
            new object[] { new[] { decimal.Zero, decimal.Zero }, 2 },
            new object[] { new[] { 1.1m, decimal.Zero, 2.2m, decimal.Zero, 3.3m }, 2 },
            new object[] { new[] { decimal.Zero, 1.1m, decimal.Zero, 2.2m, 3.3m, decimal.Zero, decimal.Zero }, 4 },
        };

        [Test]
        public void GetFalseValueCount_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetFalseValueCount(null));
        }

        [TestCase(new[] { false, true, true, false, false, false, true, false }, ExpectedResult = 5)]
        [TestCase(new[] { true, true, true, true, true, true, true, true }, ExpectedResult = 0)]
        [TestCase(new[] { false, true, true, true, true, true, true, false }, ExpectedResult = 2)]
        [TestCase(new[] { false, false, true, true, true, false, false, true }, ExpectedResult = 4)]
        [TestCase(new[] { false, true, false, false, true, true, true, false, false, true, true, false, false, false, true, false }, ExpectedResult = 9)]
        public int GetFalseValueCount_ParametersAreValid_ReturnResult(bool[] arrayToSearch)
        {
            // Act
            return DoWhileMethods.GetFalseValueCount(arrayToSearch);
        }

    }
}
