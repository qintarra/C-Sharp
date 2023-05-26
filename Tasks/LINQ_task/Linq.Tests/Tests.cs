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

        #region Middle
        [Test]
        public void Task6Test()
        {
            foreach (var (numbers, stringList, expected) in Task6Data())
            {
                var actualResult = Tasks.Task6(numbers, stringList);
                AssertIsLinq(actualResult);
                AssertIsAsExpected(expected.OrderBy(x => x), actualResult.OrderBy(x => x));
            }
        }

        [Test]
        public void Task7Test()
        {
            foreach (var (k, integerList, expected) in Task7Data())
            {
                var actualResult = Tasks.Task7(k, integerList);
                AssertIsLinq(actualResult);
                AssertIsAsExpected(expected, actualResult);
            }
        }

        [Test]
        public void Task8Test()
        {
            foreach (var (k, d, integerList, expected) in Task8Data())
            {
                var actualResult = Tasks.Task8(k, d, integerList);
                AssertIsLinq(actualResult);
                AssertIsAsExpected(expected, actualResult);
            }
        }

        [Test]
        public void Task9Test()
        {
            foreach (var (stringList, expected) in Task9Data())
            {
                var actualResult = Tasks.Task9(stringList);
                AssertIsLinq(actualResult);
                AssertIsAsExpected(expected, actualResult);
            }
        }

        [Test]
        public void Task10Test()
        {
            foreach (var (stringList, expected) in Task10Data())
            {
                var actualResult = Tasks.Task10(stringList);
                AssertIsLinq(actualResult);
                AssertIsAsExpected(expected, actualResult);
            }
        }
        private IEnumerable<(IEnumerable<int> numbers, IEnumerable<string> stringList, IEnumerable<string> expected)> Task6Data()
        {
            yield return (
                numbers: new []{ 4, 1, 6 },
                stringList: new []{ "qwer", "5qwer", "3qwe", "7qwert", "q" },
                expected: new []{ "3qwe", "Not found", "7qwert" });
            yield return (
                numbers: new[] { 4, 1, 6, 3, 12 },
                stringList: new[] { "2qwe", "4qwe", "5", "3qwe", "7qwert", "1 the 12long" },
                expected: new[] { "2qwe", "5", "7qwert", "Not found", "1 the 12long" });
            yield return (
                numbers: new[] { 7, 1, Int32.MaxValue },
                stringList: new[] { "qwer", "5qwer", "3qwe", "0qwerty" },
                expected: new[] { "0qwerty", "Not found", "Not found" });
            yield return (
                numbers: new[] { 44, 21, 78 },
                stringList: new[] { "qwer", "5qwer", "3qwe", "7qwert" },
                expected: new[] { "Not found", "Not found", "Not found" });
        }

        private IEnumerable<(int k, IEnumerable<int> integerList, IEnumerable<int> expected)> Task7Data()
        {
            yield return (
                k: 2,
                integerList: new[] { 1, 3, 78, 96, 76, 45, 5, -89, 56, 41 },
                expected: new List<int>());
            yield return (
                k: 20,
                integerList: new[] { 1, 3, 76, 96, 78, 45, 3, -89, 56, 41 },
                expected: new[] { 56, 78, 96, 76 } );
            yield return (
                k: 5,
                integerList: new[] { 1, 12, 14, 7, 92, 5, 423, 11, 47, 71, 43 },
                expected: new [] {92, 14, 12});
            yield return (
                k: 7,
                integerList: new[] { 1, 73, 45, 87, 45, 19, 13, 44, 76, -78 },
                expected: new List<int>());
        }
        
        private IEnumerable<(int k, int d, IEnumerable<int> integerList, IEnumerable<int> expected)> Task8Data()
        {
            yield return (
                k: 3,
                d: 25,
                integerList: new[] { 12, 17, 18, 19, 25, 14, 45, 71, 63, 78, 11 },
                expected: new[] { 78, 71, 63, 45, 25, 19, 18, 17, 14, 12, 11 });
            yield return (
                k: 30,
                d: 1,
                integerList: new[] { 12, 17, 18, 19, 25, 14, 45, 71, 63, 78, 11 },
                expected: new List<int>());
            yield return (
                k: 8,
                d: 1,
                integerList: new[] { 12, 17, 18, 19, 25, 14, 45, 71, 63, 78, 11 },
                expected: new [] { 78, 63, 11 });
            yield return (
                k: 15,
                d: 25,
                integerList: new[] { 12, 17, 18, 19, 25, 14, 45, 71, 63, 78, 11 },
                expected: new[] { 25, 19, 18, 17, 14, 12 });
        }
        
        private IEnumerable<(IEnumerable<string> stringList, IEnumerable<string> expected)> Task9Data()
        {
            yield return (
                stringList: new[] { "YELLOW", "GREEN", "YIELD" },
                expected: new[] { "11-Y", "5-G" });
            yield return (
                stringList: new[] { "FIREE", "FIGHTER", "AGGREGATE", "ACE" },
                expected: new[] { "12-A", "12-F" });
            yield return (
                stringList: new[]
                {
                    "EPAM", "GOOGLE", "MICROSOFT", "APPLE", "TESLA", "STARLINK", "TWITTER"
                },
                expected: new []
                {
                    "12-T", "9-M", "8-S", "6-G", "5-A", "4-E"
                });
        }

        private IEnumerable<(IEnumerable<string> stringList, IEnumerable<string> expected)> Task10Data()
        {
            yield return (
                stringList: new[] { "bc", "sd", "ac", "sdf", "ewr" },
                expected: new[] { "CCD", "RF" });
            yield return (
                stringList: new[] { "du", "the", "ace", "run", "cut" },
                expected: new[] { "ETNE", "U" });
            yield return (
                stringList: new[] { "ab", "attribute", "cheese", "swim", "cut" },
                expected: new[] { "B", "E", "E", "T", "M" });
            yield return (
                stringList: new[] { "star", "galaxy", "quasar", "planet", "asteroid", "satellite", "comet" },
                expected: new[] { "YTR", "D", "T", "E", "R" });
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