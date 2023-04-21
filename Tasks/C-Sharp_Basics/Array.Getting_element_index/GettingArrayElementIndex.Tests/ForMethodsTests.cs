using NUnit.Framework;
using static GettingArrayElementIndex.ForMethods;

// ReSharper disable StringLiteralTypo
namespace GettingArrayElementIndex.Tests
{
    [TestFixture]
    public sealed class ForMethodsTests
    {
        [Test]
        public void GetIndexOf_NullArray_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => GetIndexOf(null, 0));
        }

        [TestCase(new uint[0], 0u, ExpectedResult = -1)]
        [TestCase(new uint[] { 0, 1, 2, 3, 1, 2, 3 }, 0u, ExpectedResult = 0)]
        [TestCase(new uint[] { 0, 1, 2, 3, 1, 2, 3 }, 1u, ExpectedResult = 1)]
        [TestCase(new uint[] { 0, 1, 2, 3, 1, 2, 3 }, 2u, ExpectedResult = 2)]
        [TestCase(new uint[] { 0, 1, 2, 3, 1, 2, 3 }, 3u, ExpectedResult = 3)]
        [TestCase(new uint[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9u, ExpectedResult = 9)]
        [TestCase(new uint[] { 0, 1, 2, 3, 1, 2, 3 }, 4u, ExpectedResult = -1)]
        public int GetIndexOf_NonEmptyArray_ReturnsPosition(uint[] arrayToSearch, uint value)
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

    }
}
