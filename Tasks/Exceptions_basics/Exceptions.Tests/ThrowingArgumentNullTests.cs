﻿namespace Exceptions.Tests
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

        [Test]
        public void CheckParameterAndThrowException4_S_IsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                try
                {
                    ThrowingArgumentNull.CheckParameterAndThrowException4(null);
                }
                catch (ArgumentNullException e)
                {
                    Assert.AreEqual("s", e.ParamName);
                    throw;
                }
            });
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("a", ExpectedResult = 1)]
        [TestCase("ab", ExpectedResult = 2)]
        [TestCase("abc", ExpectedResult = 3)]
        public int CheckParameterAndThrowException4_S_IsNotNull_ReturnsString(string s)
        {
            // Act
            int actualResult = ThrowingArgumentNull.CheckParameterAndThrowException4(s);

            return actualResult;
        }

        [TestCase(null, "abc", "s1")]
        [TestCase("abc", null, "s2")]
        public void CheckParametersAndThrowException5_ArgumentIsNull_ThrowsArgumentNullException(string s1, string s2, string paramName)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                try
                {
                    ThrowingArgumentNull.CheckParametersAndThrowException5(s1, s2);
                }
                catch (ArgumentNullException e)
                {
                    Assert.AreEqual(paramName, e.ParamName);
                    throw;
                }
            });
        }

        [TestCase("", "abc", ExpectedResult = 3)]
        [TestCase("abc", "", ExpectedResult = 3)]
        [TestCase("a", "a", ExpectedResult = 2)]
        [TestCase("ab", "ab", ExpectedResult = 4)]
        [TestCase("abc", "abc", ExpectedResult = 6)]
        public int CheckParametersAndThrowException5_ArgumentsAreNotNull_ReturnsString(string s1, string s2)
        {
            int actualResult = ThrowingArgumentNull.CheckParametersAndThrowException5(s1, s2);

            return actualResult;
        }

        [TestCase(null, new int[] { }, new string[] { }, "s")]
        [TestCase("", null, new string[] { }, "integers")]
        [TestCase("", new int[] { }, null, "strings")]
        public void CheckParametersAndThrowException6_ArgumentIsNull_ThrowsArgumentNullException(string s, int[] integers, string[] strings, string paramName)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                try
                {
                    ThrowingArgumentNull.CheckParametersAndThrowException6(s, integers, strings);
                }
                catch (ArgumentNullException e)
                {
                    Assert.AreEqual(paramName, e.ParamName);
                    throw;
                }
            });
        }

        [TestCase("", new int[] { 1, 2, 3 }, new string[] { "a", "b", "c" }, ExpectedResult = 6)]
        [TestCase("abc", new int[] { }, new string[] { "a", "b", "c" }, ExpectedResult = 6)]
        [TestCase("abc", new int[] { 1, 2, 3 }, new string[] { }, ExpectedResult = 6)]
        [TestCase("a", new int[] { 1 }, new string[] { "a" }, ExpectedResult = 3)]
        [TestCase("ab", new int[] { 1, 2 }, new string[] { "a", "b" }, ExpectedResult = 6)]
        [TestCase("abc", new int[] { 1, 2, 3 }, new string[] { "a", "b", "c" }, ExpectedResult = 9)]
        public int CheckParametersAndThrowException6_ArgumentsAreNotNull_ReturnsString(string s, int[] integers, string[] strings)
        {
            int actualResult = ThrowingArgumentNull.CheckParametersAndThrowException6(s, integers, strings);

            return actualResult;
        }


    }
}
