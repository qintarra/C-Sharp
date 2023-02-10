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

    }
}
