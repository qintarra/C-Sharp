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

        [TestCase(null, new long[] { }, new float[] { }, "integers")]
        [TestCase(new int[] { }, null, new float[] { }, "longs")]
        [TestCase(new int[] { }, new long[] { }, null, "floats")]
        public void CheckParametersAndThrowException3_ArgumentIsNull_ThrowsArgumentNullException(int[] integers, long[] longs, float[] floats, string paramName)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                try
                {
                    ThrowingArgumentNull.CheckParametersAndThrowException3(integers, longs, floats);
                }
                catch (ArgumentNullException e)
                {
                    Assert.AreEqual(paramName, e.ParamName);
                    throw;
                }
            });
        }

        [TestCase(new int[] { }, new long[] { }, new float[] { }, ExpectedResult = 0)]
        [TestCase(new int[] { 1 }, new long[] { }, new float[] { }, ExpectedResult = 1)]
        [TestCase(new int[] { }, new long[] { 1L }, new float[] { }, ExpectedResult = 1)]
        [TestCase(new int[] { }, new long[] { }, new float[] { 1.1f }, ExpectedResult = 1)]
        [TestCase(new int[] { 1 }, new long[] { 1L }, new float[] { 1.1f }, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 2, 3 }, new long[] { 1L, 2L, 3L }, new float[] { 1.1f, 2.2f, 3.3f }, ExpectedResult = 9)]
        public int CheckParametersAndThrowException3_ArgumentsAreNotNull_ReturnsTrue(int[] integers, long[] longs, float[] floats)
        {
            int actualResult = ThrowingArgumentNull.CheckParametersAndThrowException3(integers, longs, floats);

            return actualResult;
        }

    }
}
