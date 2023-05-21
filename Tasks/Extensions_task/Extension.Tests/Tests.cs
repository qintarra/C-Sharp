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

        [TestCase((uint)132, (ulong)363)]
        [TestCase((uint)9, (ulong)18)]
        [TestCase((uint)0, (ulong)0)]
        [TestCase((uint)8421, (ulong)9669)]
        [TestCase((uint)74, (ulong)121)]
        public void SummaWithReverse_WithUintValue_ReturnSum(uint n, ulong expected)
        {
            //Act 
            var actualResult = n.SummaWithReverse();// MyExtensions.SummaWithReverse(n);
                                                    //Assert
            Assert.AreEqual(expected, actualResult, message: "SummaWithReverse works incorrect");
        }

    }
}
