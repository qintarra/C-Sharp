namespace Bools.Tests
{
    [TestFixture]
    public class LogicalPuzzlesTests
    {
        [TestCase(false, false, ExpectedResult = true)]
        [TestCase(true, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = true)]
        [TestCase(true, true, ExpectedResult = true)]
        public bool Puzzle1_ReturnBool(bool b1, bool b2)
        {
            return LogicalPuzzles.Puzzle1(b1, b2);
        }

    }
}
