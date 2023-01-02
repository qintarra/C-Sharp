namespace Bools.Tests
{
    [TestFixture]
    public class LogicalOperatorsTests
    {
        [TestCase(false, false, ExpectedResult = false)]
        [TestCase(true, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = false)]
        [TestCase(true, true, ExpectedResult = true)]
        public static bool LogicalAnd1_ReturnBool(bool b1, bool b2)
        {
            return LogicalOperators.LogicalAnd1(b1, b2);
        }



    }
}
