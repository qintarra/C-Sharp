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

    }
}
