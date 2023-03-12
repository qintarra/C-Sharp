global using NUnit.Framework;

namespace WhileStatements.Tests
{
    [TestFixture]
    public class ArithmeticSequencesTests
    {
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 0)]
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(1, 3, ExpectedResult = 6)]
        [TestCase(1, 4, ExpectedResult = 10)]
        [TestCase(1, 5, ExpectedResult = 15)]
        [TestCase(2, 0, ExpectedResult = 0)]
        [TestCase(2, 1, ExpectedResult = 2)]
        [TestCase(2, 2, ExpectedResult = 5)]
        [TestCase(2, 3, ExpectedResult = 9)]
        [TestCase(2, 4, ExpectedResult = 14)]
        [TestCase(2, 5, ExpectedResult = 20)]
        [TestCase(3, 0, ExpectedResult = 0)]
        [TestCase(3, 1, ExpectedResult = 3)]
        [TestCase(3, 2, ExpectedResult = 7)]
        [TestCase(3, 3, ExpectedResult = 12)]
        [TestCase(3, 4, ExpectedResult = 18)]
        [TestCase(3, 5, ExpectedResult = 25)]
        [TestCase(4, 0, ExpectedResult = 0)]
        [TestCase(4, 1, ExpectedResult = 4)]
        [TestCase(4, 2, ExpectedResult = 9)]
        [TestCase(4, 3, ExpectedResult = 15)]
        [TestCase(4, 4, ExpectedResult = 22)]
        [TestCase(4, 5, ExpectedResult = 30)]
        [TestCase(5, 0, ExpectedResult = 0)]
        [TestCase(5, 1, ExpectedResult = 5)]
        [TestCase(5, 2, ExpectedResult = 11)]
        [TestCase(5, 3, ExpectedResult = 18)]
        [TestCase(5, 4, ExpectedResult = 26)]
        [TestCase(5, 5, ExpectedResult = 35)]
        public int SumArithmeticSequenceTerms1_ReturnsSum(int a, int n)
        {
            return ArithmeticSequences.SumArithmeticSequenceTerms1(a, n);
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 17)]
        [TestCase(2, ExpectedResult = 67)]
        [TestCase(3, ExpectedResult = 150)]
        [TestCase(4, ExpectedResult = 266)]
        [TestCase(5, ExpectedResult = 415)]
        [TestCase(6, ExpectedResult = 597)]
        [TestCase(7, ExpectedResult = 812)]
        [TestCase(8, ExpectedResult = 1060)]
        [TestCase(9, ExpectedResult = 1341)]
        [TestCase(10, ExpectedResult = 1655)]
        public int SumArithmeticSequenceTerms2_ReturnsSum(int n)
        {
            return ArithmeticSequences.SumArithmeticSequenceTerms2(n);
        }


    }
}
