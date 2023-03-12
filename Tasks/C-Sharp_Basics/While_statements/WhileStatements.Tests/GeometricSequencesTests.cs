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

        [TestCase(1u, ExpectedResult = 13u)]
        [TestCase(2u, ExpectedResult = 52u)]
        [TestCase(3u, ExpectedResult = 169u)]
        [TestCase(4u, ExpectedResult = 520u)]
        [TestCase(5u, ExpectedResult = 1573u)]
        [TestCase(6u, ExpectedResult = 4732u)]
        [TestCase(7u, ExpectedResult = 14209u)]
        [TestCase(8u, ExpectedResult = 42640u)]
        [TestCase(9u, ExpectedResult = 127933u)]
        [TestCase(10u, ExpectedResult = 383812u)]
        [TestCase(11u, ExpectedResult = 1151449u)]
        [TestCase(12u, ExpectedResult = 3454360u)]
        [TestCase(13u, ExpectedResult = 10363093u)]
        [TestCase(14u, ExpectedResult = 31089292u)]
        [TestCase(15u, ExpectedResult = 93267889u)]
        public uint SumGeometricSequenceTerms2_ReturnsSum(uint n)
        {
            return GeometricSequences.SumGeometricSequenceTerms2(n);
        }

    }
}
