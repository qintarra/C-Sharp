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

        private IEnumerable<(char c, IEnumerable<string> stringList, IEnumerable<string> expected)> Task1Data()
        {
            yield return (
                c: 'a',
                stringList: new[] { "a fkgfjkgfgmk a", "a", "adddddd", "ddddddda" },
                expected: new[] { "a fkgfjkgfgmk a" });
            yield return (
                c: 'g',
                stringList: new[] { "gf", "g", "gdddddd", "dddddddg" },
                expected: new List<string>());
            yield return (
                c: 'B',
                stringList: new[] { "BETA", "BETA B", "Be or not to be", "some sentence with B" },
                expected: new[] { "BETA B" });
            yield return (
                c: '+',
                stringList: new[] { "c++", "+-+", "+6987/", "+478+" },
                expected: new[] { "+-+", "+478+" });
        }

        private IEnumerable<(IEnumerable<string> stringList, IEnumerable<int> expected)> Task2Data()
        {
            yield return (
                stringList: new[] { "ddddddaaa", "dsjhdfoiwhveuvn", "hvbrurhvuirevhreuivguvvhu" },
                expected: new[] { 9, 15, 25 });
            yield return (
                stringList: new[] { "dddddd", "ddddd", "ddd", "dd", "d" },
                expected: new[] { 1, 2, 3, 5, 6 });
            yield return (
                stringList: new[]
                {
                    "turn", "cap", "the string dudududu", "some sentence with B",
                    "fertility", "the sharp", "some string", ""
                },
                expected: new[]
                {
                    0, 3, 4, 9, 9, 11, 19, 20
                });
        }

        private IEnumerable<(IEnumerable<string> stringList, IEnumerable<string> expected)> Task3Data()
        {
            yield return (
                stringList: new[] { "ehgrtthrehrehrehre", "fjjgoerugrjgrehg", "jgnjirgbrnigeheruwqqeughweirjewew" },
                expected: new[] { "ee", "fg", "jw" });
            yield return (
                stringList: new[] { "756998/*+fgh", "urhrhgu48GH", "SssssS", "the something;", "hello" },
                expected: new[] { "7h", "uH", "SS", "t;", "ho" });
            yield return (
                stringList: new[]
                {
                    "&ghjjpgirbigjrg5985849*///grgerge", "#fkgjklgflgk@", "irejgkerogruoj^", "some sentence with B",
                    "fertility", "the sharp", "some string", "a"
                },
                expected: new[]
                {
                    "&e", "#@", "i^", "sB",
                    "fy", "tp", "sg", "aa"
                });
        }

        private IEnumerable<(int k, IEnumerable<string> stringList, IEnumerable<string> expected)> Task4Data()
        {
            yield return (
                k: 1,
                stringList: new[] { "1", "f3", "8" },
                expected: new[] { "1", "8" });
            yield return (
                k: 4,
                stringList: new[] { "345e", "ABC1", "1437", "FGE3", "fire1" },
                expected: new[] { "1437", "ABC1", "FGE3" });
            yield return (
                k: 0,
                stringList: new[]
                {
                    "1", "5", "bc", "ABC1",
                    "fertility", "the sharp", "some string", "a"
                },
                expected: new List<string>());
            yield return (
                k: 12,
                stringList: new[]
                {
                    "the big cup2", "#fkgjklgflgk2", "The objection", "###########1",
                    "fertility", "the big cup1", "some string", "a"
                },
                expected: new[]
                {
                    "###########1", "the big cup1", "the big cup2"
                });
        }

        private IEnumerable<(IEnumerable<int> integerList, IEnumerable<string> expected)> Task5Data()
        {
            yield return (
                integerList: new[] { 140, 45, 14, 0, 15, 147 },
                expected: new[] { "15", "45", "147" });
            yield return (
                integerList: new[] { 190, 56, 47, 5681, 45, 89652, 7893 },
                expected: new[] { "45", "47", "5681", "7893" });
            yield return (
                integerList: new[] { 93, 45, 789, 456, 45, 78, 235, 896, 4563 },
                expected: new[] { "45", "45", "93", "235", "789", "4563" });
            yield return (
                integerList: new[] { 92, 42, 782, 456, 44, 78, 236, 896, 4562 },
                expected: new List<string>());
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