using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Objects;
using NUnit.Framework;
using Linq.Tests.Comparers;

namespace Linq.Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly YearSchoolComparer _yearSchoolComparer = new YearSchoolComparer();
        private readonly NumberPairComparer _numberPairComparer = new NumberPairComparer();
        private readonly MaxDiscountOwnerComparer _discountOwnerComparer = new MaxDiscountOwnerComparer();
        private readonly CountryStatComparer _countryStatComparer = new CountryStatComparer();

        #region Low

        [Test]
        public void Task1Test()
        {
            foreach (var (c, stringList, expected) in Task1Data())
            {
                var actualResult = Tasks.Task1(c, stringList);
                AssertIsLinq(actualResult);
                AssertIsAsExpected(expected.OrderBy(x => x), actualResult.OrderBy(x => x));
            }
        }

        [Test]
        public void Task2Test()
        {
            foreach (var (stringList, expected) in Task2Data())
            {
                var actualResult = Tasks.Task2(stringList);
                AssertIsLinq(actualResult);
                AssertIsAsExpected(expected, actualResult);
            }
        }

        [Test]
        public void Task3Test()
        {
            foreach (var (stringList, expected) in Task3Data())
            {
                var actualResult = Tasks.Task3(stringList);
                AssertIsLinq(actualResult);
                AssertIsAsExpected(expected.OrderBy(x => x), actualResult.OrderBy(x => x));
            }
        }

        [Test]
        public void Task4Test()
        {
            foreach (var (k, stringList, expected) in Task4Data())
            {
                var actualResult = Tasks.Task4(k, stringList);
                AssertIsLinq(actualResult);
                AssertIsAsExpected(expected, actualResult);
            }
        }

        [Test]
        public void Task5Test()
        {
            foreach (var (integerList, expected) in Task5Data())
            {
                var actualResult = Tasks.Task5(integerList);
                AssertIsLinq(actualResult);
                AssertIsAsExpected(expected, actualResult);
            }
        }



        #endregion

        #region Utility

        private void AssertIsLinq<T>(IEnumerable<T> result)
        {
            Assert.AreEqual("System.Linq", result.GetType().Namespace, "Result is not linq");
        }

        private void AssertIsAsExpected<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            Assert.AreEqual(expected, actual);
        }

        private void AssertIsAsExpected<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer)
        {
            Assert.True(expected.SequenceEqual(actual, comparer), "Result is not as expected");
        }

        #endregion
    }
}