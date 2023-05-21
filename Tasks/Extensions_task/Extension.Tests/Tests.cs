using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Extension.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(1074, 12)]
        [TestCase(-4678, 25)]
        [TestCase(0, 0)]
        [TestCase(02, 2)]
        [TestCase(333333, 18)]
        public void SummaDigit_WithIntegerValue_ReturntSumOfDigits(int n, int expected)
        {
            //Act 
            var actualResult = n.SummaDigit();// MyExtensions.SummaDigit(n);

            //Assert 
            Assert.AreEqual(expected, actualResult, message: "SummaDigit method works incorrect ");
        }

    }
}
