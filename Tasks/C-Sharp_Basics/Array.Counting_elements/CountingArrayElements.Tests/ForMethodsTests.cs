using NUnit.Framework;

namespace CountingArrayElements.Tests
{
    [TestFixture]
    public sealed class ForMethodsTests
    {
        [Test]
        public void GetNegativeIntegerCount_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetNegativeIntegerCount(null));
        }

    }
}
