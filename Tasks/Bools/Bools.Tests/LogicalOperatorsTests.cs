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

        [TestCase(false, false, false, ExpectedResult = false)]
        [TestCase(true, false, false, ExpectedResult = false)]
        [TestCase(false, true, false, ExpectedResult = false)]
        [TestCase(false, false, true, ExpectedResult = false)]
        [TestCase(true, true, false, ExpectedResult = false)]
        [TestCase(true, false, true, ExpectedResult = false)]
        [TestCase(false, true, true, ExpectedResult = false)]
        [TestCase(true, true, true, ExpectedResult = true)]
        public static bool LogicalAnd2_ReturnBool(bool b1, bool b2, bool b3)
        {
            return LogicalOperators.LogicalAnd2(b1, b2, b3);
        }



    }
}
