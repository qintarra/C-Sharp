namespace ForStatements.Tests
{
    [TestFixture]
    public class FibonacciSequenceTests
    {
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 2)]
        [TestCase(4, ExpectedResult = 3)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(6, ExpectedResult = 8)]
        [TestCase(7, ExpectedResult = 13)]
        [TestCase(8, ExpectedResult = 21)]
        [TestCase(9, ExpectedResult = 34)]
        [TestCase(10, ExpectedResult = 55)]
        [TestCase(11, ExpectedResult = 89)]
        [TestCase(12, ExpectedResult = 144)]
        [TestCase(13, ExpectedResult = 233)]
        [TestCase(14, ExpectedResult = 377)]
        public int GetFibonacciNumber_ReturnsNumber(int n)
        {
            return FibonacciSequence.GetFibonacciNumber(n);
        }
    }
}
