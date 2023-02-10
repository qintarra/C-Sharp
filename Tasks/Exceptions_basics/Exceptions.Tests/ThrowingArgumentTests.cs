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

        [TestCase(1u)]
        [TestCase(2u)]
        [TestCase(3u)]
        [TestCase(4u)]
        [TestCase(5u)]
        [TestCase(6u)]
        [TestCase(7u)]
        [TestCase(8u)]
        [TestCase(9u)]
        [TestCase(10u)]
        public void CheckParameterAndThrowException2_S_IsNotZero_ReturnsInteger(uint s)
        {
            int actualResult = ThrowingArgument.CheckParameterAndThrowException2((ushort)s);

            Assert.AreEqual(s, actualResult);
        }

        [TestCase(0L)]
        [TestCase(2L)]
        [TestCase(4L)]
        [TestCase(6L)]
        [TestCase(8L)]
        [TestCase(10L)]
        [TestCase(-2L)]
        [TestCase(-4L)]
        [TestCase(-6L)]
        [TestCase(-8L)]
        [TestCase(-10L)]
        public void CheckParameterAndThrowException3_I_IsEven_ThrowsArgumentException(long l)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                try
                {
                    ThrowingArgument.CheckParameterAndThrowException3(l);
                }
                catch (ArgumentException e)
                {
                    Assert.AreEqual(nameof(l), e.ParamName);
                    Assert.AreEqual("l should not be even. (Parameter 'l')", e.Message);
                    throw;
                }
            });
        }

        [TestCase(1L)]
        [TestCase(3L)]
        [TestCase(5L)]
        [TestCase(7L)]
        [TestCase(9L)]
        [TestCase(11L)]
        [TestCase(-1L)]
        [TestCase(-3L)]
        [TestCase(-5L)]
        [TestCase(-9L)]
        [TestCase(-11L)]
        public void CheckParameterAndThrowException3_I_IsOdd_ReturnsInteger(long l)
        {
            long actualResult = ThrowingArgument.CheckParameterAndThrowException3(l);

            Assert.AreEqual(l, actualResult);
        }

    }
}
