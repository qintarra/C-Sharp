using System;
using NUnit.Framework;

namespace LookingForArrayElements.Tests
{
    [TestFixture]
    public sealed class IntegersCounterTests
    {
        [Test]
        public void GetIntegersCount_ArrayToSearchIsNull_ThrowArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(
                () => IntegersCounter.GetIntegersCount(null, Array.Empty<int>()),
                message: "Method throws ArgumentNullException in case an array to search is null.");
        }

    }
}
