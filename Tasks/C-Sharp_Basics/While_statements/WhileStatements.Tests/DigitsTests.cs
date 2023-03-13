namespace WhileStatements.Tests
{
    [TestFixture]
    public class DigitsTests
    {
        [TestCase(0ul, ExpectedResult = 0ul)]
        [TestCase(1ul, ExpectedResult = 1ul)]
        [TestCase(10ul, ExpectedResult = 1ul)]
        [TestCase(11ul, ExpectedResult = 2ul)]
        [TestCase(12ul, ExpectedResult = 3ul)]
        [TestCase(13ul, ExpectedResult = 4ul)]
        [TestCase(14ul, ExpectedResult = 5ul)]
        [TestCase(15ul, ExpectedResult = 6ul)]
        [TestCase(16ul, ExpectedResult = 7ul)]
        [TestCase(17ul, ExpectedResult = 8ul)]
        [TestCase(18ul, ExpectedResult = 9ul)]
        [TestCase(19ul, ExpectedResult = 10ul)]
        [TestCase(20ul, ExpectedResult = 2ul)]
        [TestCase(30ul, ExpectedResult = 3ul)]
        [TestCase(39ul, ExpectedResult = 12ul)]
        [TestCase(40ul, ExpectedResult = 4ul)]
        [TestCase(41ul, ExpectedResult = 5ul)]
        [TestCase(50ul, ExpectedResult = 5ul)]
        [TestCase(55ul, ExpectedResult = 10ul)]
        [TestCase(100ul, ExpectedResult = 1ul)]
        [TestCase(101ul, ExpectedResult = 2ul)]
        [TestCase(110ul, ExpectedResult = 2ul)]
        [TestCase(111ul, ExpectedResult = 3ul)]
        [TestCase(200ul, ExpectedResult = 2ul)]
        [TestCase(202ul, ExpectedResult = 4ul)]
        [TestCase(220ul, ExpectedResult = 4ul)]
        [TestCase(222ul, ExpectedResult = 6ul)]
        [TestCase(123ul, ExpectedResult = 6ul)]
        [TestCase(132ul, ExpectedResult = 6ul)]
        [TestCase(231ul, ExpectedResult = 6ul)]
        [TestCase(213ul, ExpectedResult = 6ul)]
        [TestCase(321ul, ExpectedResult = 6ul)]
        [TestCase(312ul, ExpectedResult = 6ul)]
        public ulong GetDigitsSum_ReturnsSum(ulong l)
        {
            return Digits.GetDigitsSum(l);
        }

    }
}
