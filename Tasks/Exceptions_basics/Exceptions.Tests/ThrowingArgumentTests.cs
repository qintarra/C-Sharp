namespace Exceptions.Tests
{
    [TestFixture]
    public class ThrowingArgumentTests
    {
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(9)]
        [TestCase(11)]
        [TestCase(-1)]
        [TestCase(-3)]
        [TestCase(-5)]
        [TestCase(-7)]
        [TestCase(-9)]
        [TestCase(-11)]
        public void CheckParameterAndThrowException1_I_IsOdd_ThrowsArgumentException(int i)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                try
                {
                    ThrowingArgument.CheckParameterAndThrowException1(i);
                }
                catch (ArgumentException e)
                {
                    Assert.AreEqual(nameof(i), e.ParamName);
                    Assert.AreEqual("i should not be odd. (Parameter 'i')", e.Message);
                    throw;
                }
            });
        }

        [TestCase(0)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(8)]
        [TestCase(10)]
        [TestCase(-2)]
        [TestCase(-4)]
        [TestCase(-6)]
        [TestCase(-8)]
        [TestCase(-10)]
        public void CheckParameterAndThrowException1_I_IsEven_ReturnsInteger(int i)
        {
            int actualResult = ThrowingArgument.CheckParameterAndThrowException1(i);

            Assert.AreEqual(i, actualResult);
        }

        [Test]
        public void CheckParameterAndThrowException2_I_IsZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                try
                {
                    ThrowingArgument.CheckParameterAndThrowException2(0);
                }
                catch (ArgumentException e)
                {
                    Assert.AreEqual("s", e.ParamName);
                    Assert.AreEqual("s should not equals zero. (Parameter 's')", e.Message);
                    throw;
                }
            });
        }

    }
}
