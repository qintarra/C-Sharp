namespace Exceptions.Tests
{
    [TestFixture]
    public class ThrowingArgumentNullTests
    {
        [Test]
        public void CheckParameterAndThrowException1_O_IsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                try
                {
                    ThrowingArgumentNull.CheckParameterAndThrowException1(null);
                }
                catch (ArgumentNullException e)
                {
                    Assert.AreEqual("o", e.ParamName);
                    throw;
                }
            });
        }

        [Test]
        public void CheckParameterAndThrowException1_O_IsNotNull_ReturnsTrue()
        {
            // Act
            bool actualResult = ThrowingArgumentNull.CheckParameterAndThrowException1(new object());

            // Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void CheckParametersAndThrowException2_O1_IsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                try
                {
                    ThrowingArgumentNull.CheckParametersAndThrowException2(null, new object());
                }
                catch (ArgumentNullException e)
                {
                    Assert.AreEqual("o1", e.ParamName);
                    throw;
                }
            });
        }

        [Test]
        public void CheckParametersAndThrowException2_O2_IsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                try
                {
                    ThrowingArgumentNull.CheckParametersAndThrowException2(new object(), null);
                }
                catch (ArgumentNullException e)
                {
                    Assert.AreEqual("o2", e.ParamName);
                    throw;
                }
            });
        }

        [Test]
        public void CheckParametersAndThrowException2_ArgumentsAreNotNull_ReturnsTrue()
        {
            // Act
            bool actualResult = ThrowingArgumentNull.CheckParametersAndThrowException2(new object(), new object());

            // Assert
            Assert.IsTrue(actualResult);
        }

    }
}
