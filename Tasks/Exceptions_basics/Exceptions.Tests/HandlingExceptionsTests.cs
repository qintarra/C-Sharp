﻿namespace Exceptions.Tests
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

    }
}
