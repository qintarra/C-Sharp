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

    }
}
