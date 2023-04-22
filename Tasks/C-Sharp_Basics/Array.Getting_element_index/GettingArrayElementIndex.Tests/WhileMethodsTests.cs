using NUnit.Framework;
using static GettingArrayElementIndex.WhileMethods;

// ReSharper disable StringLiteralTypo
namespace GettingArrayElementIndex.Tests
{
    [TestFixture]
    public sealed class WhileMethodsTests
    {
        [Test]
        public void GetIndexOf_NullArray_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => GetIndexOf(null, 0));
        }

        [TestCase(new ushort[0], (ushort)0, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)0, ExpectedResult = 0)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)1, ExpectedResult = 1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)2, ExpectedResult = 2)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)3, ExpectedResult = 3)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, (ushort)9, ExpectedResult = 9)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)4, ExpectedResult = -1)]
        public int GetIndexOf_NonEmptyArray_ReturnsPosition(ushort[] arrayToSearch, ushort value)
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
            Assert.Throws<ArgumentOutOfRangeException>(() => GetIndexOf(Array.Empty<ushort>(), 0, -1, 0));
        }

        [Test]
        public void GetIndexOf_StartIndexCount_StartIndexGreaterArrayLength_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetIndexOf(Array.Empty<ushort>(), 0, 1, 0));
        }

        [Test]
        public void GetIndexOf_StartIndexCount_CountLessZero_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetIndexOf(Array.Empty<ushort>(), 0, 0, -1));
        }

    }
}
