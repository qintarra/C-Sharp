namespace ForStatements.Tests
{
    [TestFixture]
    public class QuadraticSequencesTests
    {
        [TestCase(3, 5, 7, 15, ExpectedResult = 1)]
        [TestCase(3, 5, 7, 29, ExpectedResult = 2)]
        [TestCase(3, 5, 7, 49, ExpectedResult = 3)]
        [TestCase(3, 5, 7, 75, ExpectedResult = 4)]
        [TestCase(3, 5, 7, 107, ExpectedResult = 5)]
        [TestCase(3, 5, 7, 145, ExpectedResult = 6)]
        [TestCase(3, 5, 7, 189, ExpectedResult = 7)]
        [TestCase(3, 5, 7, 239, ExpectedResult = 8)]
        [TestCase(3, 5, 7, 295, ExpectedResult = 9)]
        [TestCase(3, 5, 7, 357, ExpectedResult = 10)]
        [TestCase(3, 5, 7, 425, ExpectedResult = 11)]
        [TestCase(3, 5, 7, 499, ExpectedResult = 12)]
        [TestCase(3, 5, 7, 579, ExpectedResult = 13)]
        [TestCase(3, 5, 7, 665, ExpectedResult = 14)]
        [TestCase(3, 5, 7, 757, ExpectedResult = 15)]
        public uint CountQuadraticSequenceTerms_ReturnsSum(long a, long b, long c, long maxTerm)
        {
            return QuadraticSequences.CountQuadraticSequenceTerms(a, b, c, maxTerm);
        }
    }
}
