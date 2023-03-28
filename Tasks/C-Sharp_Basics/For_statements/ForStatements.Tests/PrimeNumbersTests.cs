namespace ForStatements.Tests
{
    [TestFixture]
    public class PrimeNumbersTests
    {
        [TestCase(0u, ExpectedResult = false)]
        [TestCase(1u, ExpectedResult = false)]
        [TestCase(2u, ExpectedResult = true)]
        [TestCase(3u, ExpectedResult = true)]
        [TestCase(4u, ExpectedResult = false)]
        [TestCase(5u, ExpectedResult = true)]
        [TestCase(6u, ExpectedResult = false)]
        [TestCase(7u, ExpectedResult = true)]
        [TestCase(8u, ExpectedResult = false)]
        [TestCase(9u, ExpectedResult = false)]
        [TestCase(10u, ExpectedResult = false)]
        [TestCase(11u, ExpectedResult = true)]
        [TestCase(12u, ExpectedResult = false)]
        [TestCase(13u, ExpectedResult = true)]
        [TestCase(14u, ExpectedResult = false)]
        [TestCase(15u, ExpectedResult = false)]
        [TestCase(16u, ExpectedResult = false)]
        [TestCase(17u, ExpectedResult = true)]
        [TestCase(18u, ExpectedResult = false)]
        [TestCase(19u, ExpectedResult = true)]
        [TestCase(20u, ExpectedResult = false)]
        [TestCase(21u, ExpectedResult = false)]
        [TestCase(22u, ExpectedResult = false)]
        [TestCase(23u, ExpectedResult = true)]
        [TestCase(29u, ExpectedResult = true)]
        [TestCase(31u, ExpectedResult = true)]
        [TestCase(37u, ExpectedResult = true)]
        [TestCase(41u, ExpectedResult = true)]
        [TestCase(43u, ExpectedResult = true)]
        [TestCase(47u, ExpectedResult = true)]
        [TestCase(53u, ExpectedResult = true)]
        public bool IsPrimeNumber(uint n)
        {
            return PrimeNumbers.IsPrimeNumber(n);
        }

    }
}
