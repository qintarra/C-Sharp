namespace WhileStatements.Tests
{
    [TestFixture]
    public class GeometricSequencesTests
    {
        [TestCase(1u, 1u, 1u, ExpectedResult = 1u)]
        [TestCase(1u, 1u, 2u, ExpectedResult = 2u)]
        [TestCase(1u, 1u, 3u, ExpectedResult = 3u)]
        [TestCase(1u, 1u, 4u, ExpectedResult = 4u)]
        [TestCase(1u, 1u, 5u, ExpectedResult = 5u)]
        [TestCase(2u, 1u, 1u, ExpectedResult = 2u)]
        [TestCase(2u, 1u, 2u, ExpectedResult = 4u)]
        [TestCase(2u, 1u, 3u, ExpectedResult = 6u)]
        [TestCase(2u, 1u, 4u, ExpectedResult = 8u)]
        [TestCase(2u, 1u, 5u, ExpectedResult = 10u)]
        [TestCase(3u, 1u, 1u, ExpectedResult = 3u)]
        [TestCase(3u, 1u, 2u, ExpectedResult = 6u)]
        [TestCase(3u, 1u, 3u, ExpectedResult = 9u)]
        [TestCase(3u, 1u, 4u, ExpectedResult = 12u)]
        [TestCase(3u, 1u, 5u, ExpectedResult = 15u)]
        [TestCase(4u, 2u, 1u, ExpectedResult = 4u)]
        [TestCase(4u, 2u, 2u, ExpectedResult = 12u)]
        [TestCase(4u, 2u, 3u, ExpectedResult = 28u)]
        [TestCase(4u, 2u, 4u, ExpectedResult = 60u)]
        [TestCase(4u, 2u, 5u, ExpectedResult = 124u)]
        [TestCase(5u, 3u, 1u, ExpectedResult = 5u)]
        [TestCase(5u, 3u, 2u, ExpectedResult = 20u)]
        [TestCase(5u, 3u, 3u, ExpectedResult = 65u)]
        [TestCase(5u, 3u, 4u, ExpectedResult = 200u)]
        [TestCase(5u, 3u, 5u, ExpectedResult = 605u)]
        public uint SumGeometricSequenceTerms1_ReturnsSum(uint a, uint r, uint n)
        {
            return GeometricSequences.SumGeometricSequenceTerms1(a, r, n);
        }

    }
}
