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

    }
}
