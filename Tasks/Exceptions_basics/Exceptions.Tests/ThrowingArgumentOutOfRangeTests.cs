global using NUnit.Framework;

namespace Exceptions.Tests
{
    [TestFixture]
    public class ThrowingArgumentOutOfRangeTests
    {
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(-5)]
        [TestCase(-6)]
        [TestCase(-7)]
        [TestCase(-8)]
        [TestCase(-9)]
        [TestCase(-10)]
        public void CheckParameterAndThrowException1_ThrowsArgumentOutOfRangeException(int i)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                try
                {
                    ThrowingArgumentOutOfRange.CheckParameterAndThrowException1(i);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Assert.AreEqual(nameof(i), e.ParamName);
                    throw;
                }
            });
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(-1)]
        [TestCase(-2)]
        [TestCase(-3)]
        [TestCase(-4)]
        public void CheckParameterAndThrowException1_ReturnsTrue(int i)
        {
            // Act
            bool actualResult = ThrowingArgumentOutOfRange.CheckParameterAndThrowException1(i);

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestCase(8u)]
        [TestCase(9u)]
        [TestCase(10u)]
        public void CheckParameterAndThrowException2_ThrowsArgumentOutOfRangeException(ulong l)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                try
                {
                    ThrowingArgumentOutOfRange.CheckParameterAndThrowException2(l);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Assert.AreEqual(nameof(l), e.ParamName);
                    throw;
                }
            });
        }

        [TestCase(0uL)]
        [TestCase(1uL)]
        [TestCase(2uL)]
        [TestCase(3uL)]
        [TestCase(4uL)]
        [TestCase(5uL)]
        [TestCase(6uL)]
        [TestCase(7uL)]
        public void CheckParameterAndThrowException2_ReturnsTrue(ulong l)
        {
            // Act
            bool actualResult = ThrowingArgumentOutOfRange.CheckParameterAndThrowException2(l);

            // Assert
            Assert.IsTrue(actualResult);
        }

    }
}
