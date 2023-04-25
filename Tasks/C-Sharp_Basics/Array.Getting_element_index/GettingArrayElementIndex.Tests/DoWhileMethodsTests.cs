using NUnit.Framework;
using static GettingArrayElementIndex.DoWhileMethods;

// ReSharper disable StringLiteralTypo
namespace GettingArrayElementIndex.Tests
{
    [TestFixture]
    public sealed class DoWhileMethodsTests
    {
        [Test]
        public void GetIndexOf_NullArray_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => GetIndexOf(null, 0));
        }

        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 0ul, ExpectedResult = 0)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 1ul, ExpectedResult = 1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 2ul, ExpectedResult = 2)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 3ul, ExpectedResult = 3)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9ul, ExpectedResult = 9)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 4ul, ExpectedResult = -1)]
        public int GetIndexOf_NonEmptyArray_ReturnsPosition(ulong[] arrayToSearch, ulong value)
        {
            // Act
            return GetIndexOf(arrayToSearch, value);
        }

        [Test]
        public void GetIndexOf_StartIndexCount_NullArray_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => GetIndexOf(null, 0, 0, 0));
        }

        [Test]
        public void GetIndexOf_StartIndexCount_StartIndexLessZero_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetIndexOf(Array.Empty<ulong>(), 0, -1, 0));
        }

        [Test]
        public void GetIndexOf_StartIndexCount_StartIndexGreaterArrayLength_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetIndexOf(Array.Empty<ulong>(), 0, 1, 0));
        }

    }
}
