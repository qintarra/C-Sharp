namespace Exceptions.Tests
{
    [TestFixture]
    public class HandlingExceptionsTests
    {
        [Test]
        public void CatchArgumentOutOfRangeException1_ExceptionIsThrown_ThrowsException()
        {
            Assert.Throws<Exception>(() =>
            {
                HandlingExceptions.CatchArgumentOutOfRangeException1(1, TestArgumentOutOfRangeException);
            });
        }

        [Test]
        public void CatchArgumentOutOfRangeException1_ArgumentOutOfRangeExceptionIsThrown_ThrowsException()
        {
            bool actualResult = HandlingExceptions.CatchArgumentOutOfRangeException1(-1, TestArgumentOutOfRangeException);

            Assert.AreEqual(false, actualResult);
        }

        [Test]
        public void CatchArgumentOutOfRangeException1_I_IsValid_ReturnsNumber()
        {
            bool actualResult = HandlingExceptions.CatchArgumentOutOfRangeException1(0, TestArgumentOutOfRangeException);

            Assert.AreEqual(true, actualResult);
        }

        [TestCase(-11)]
        [TestCase(11)]
        public void CatchArgumentOutOfRangeException2_ArgumentOutOfRangeException(int i)
        {
            string actualResult = HandlingExceptions.CatchArgumentOutOfRangeException2(i, "ABC", "123", out string errorMessage);

            Assert.AreEqual("K139", actualResult);
            Assert.IsTrue(errorMessage.Contains("i should be in [-10, 10] interval.", StringComparison.InvariantCulture));
        }

    }
}
