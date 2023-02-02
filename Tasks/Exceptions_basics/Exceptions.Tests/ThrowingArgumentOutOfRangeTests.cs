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

    }
}
