﻿using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace CountingArrayElements.Tests
{
    [TestFixture]
    public sealed class WhileMethodsTests
    {
        private static readonly object[][] GetEmptyStringCountData =
        {
            new object[] { new[] { string.Empty, "abc", string.Empty, "def", string.Empty, "ghi", string.Empty }, 4 },
            new object[] { new[] { string.Empty, string.Empty, string.Empty }, 3 },
            new object[] { new[] { "ab", "cd", "ef", "gh", "ij", "kl", "mn" }, 0 },
            new object[] { new[] { "ab", string.Empty, "cd", "ef", "gh", "ij", "kl", "mn", string.Empty }, 2 },
        };

        private static readonly object[][] GetNullObjectCountData =
        {
            new object[] { new[] { null, new object(), new object(), null, null, new object(), null }, 4 },
            new object[] { new[] { new object(), new object(), new object(), new object() }, 0 },
            new object[] { new object?[] { null, null, null, null, null }, 5 },
            new object[] { new[] { new object(), new object(), null, new object(), new object() }, 1 },
        };

        [Test]
        public void GetEmptyStringCount_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => WhileMethods.GetEmptyStringCount(null));
        }

        [TestCaseSource(nameof(GetEmptyStringCountData))]
        public void GetEmptyStringCount_ParametersAreValid_ReturnsResult(string[] arrayToSearch, int expectedResult)
        {
            // Act
            int actualResult = WhileMethods.GetEmptyStringCount(arrayToSearch);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetEmptyStringCountRecursive_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => WhileMethods.GetEmptyStringCountRecursive(null));
        }

    }
}
