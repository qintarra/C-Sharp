namespace ForStatements.Tests
{
    [TestFixture]
    public class FactorialTests
    {
        [TestCase(0, ExpectedResult = 1)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(3, ExpectedResult = 6)]
        [TestCase(4, ExpectedResult = 24)]
        [TestCase(5, ExpectedResult = 120)]
        [TestCase(6, ExpectedResult = 720)]
        [TestCase(7, ExpectedResult = 5040)]
        public int GetFactorial(int n)
        {
            return Factorial.GetFactorial(n);
        }
    }
}
