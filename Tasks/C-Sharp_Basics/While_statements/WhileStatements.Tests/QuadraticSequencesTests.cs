namespace WhileStatements.Tests
{
    [TestFixture]
    public class QuadraticSequencesTests
    {
        [TestCase(3, 5, 7, 15, ExpectedResult = 15)]
        [TestCase(3, 5, 7, 29, ExpectedResult = 44)]
        [TestCase(3, 5, 7, 49, ExpectedResult = 93)]
        [TestCase(3, 5, 7, 75, ExpectedResult = 168)]
        [TestCase(3, 5, 7, 107, ExpectedResult = 275)]
        [TestCase(3, 5, 7, 145, ExpectedResult = 420)]
        [TestCase(3, 5, 7, 189, ExpectedResult = 609)]
        [TestCase(3, 5, 7, 239, ExpectedResult = 848)]
        [TestCase(3, 5, 7, 295, ExpectedResult = 1143)]
        [TestCase(3, 5, 7, 357, ExpectedResult = 1500)]
        [TestCase(3, 5, 7, 425, ExpectedResult = 1925)]
        [TestCase(3, 5, 7, 499, ExpectedResult = 2424)]
        [TestCase(3, 5, 7, 579, ExpectedResult = 3003)]
        [TestCase(3, 5, 7, 665, ExpectedResult = 3668)]
        [TestCase(3, 5, 7, 757, ExpectedResult = 4425)]
        public long SumQuadraticSequenceTerms1_ReturnsSum(long a, long b, long c, long maxTerm)
        {
            return QuadraticSequences.SumQuadraticSequenceTerms1(a, b, c, maxTerm);
        }
    }
}
