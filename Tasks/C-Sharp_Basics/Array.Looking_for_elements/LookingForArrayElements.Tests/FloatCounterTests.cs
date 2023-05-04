﻿using System;
using NUnit.Framework;

namespace LookingForArrayElements.Tests
{
    [TestFixture]
    public sealed class FloatCounterTests
    {
        private static readonly float[] ArrayWithNineElements = { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f };

        [Test]
        public void GetFloatsCount_ArrayToSearchIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(
                () => FloatCounter.GetFloatsCount(null, Array.Empty<float>(), Array.Empty<float>()),
                message: "Method throws ArgumentNullException in case an array to search is null.");
        }

        [Test]
        public void GetFloatsCount_RangeStartIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(
                () => FloatCounter.GetFloatsCount(Array.Empty<float>(), null, Array.Empty<float>()),
                message: "Method throws ArgumentNullException in case an array of range starts is null.");
        }

        [Test]
        public void GetFloatsCount_RangeEndIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(
                () => FloatCounter.GetFloatsCount(Array.Empty<float>(), Array.Empty<float>(), null),
                message: "Method throws ArgumentNullException in case an array of range ends is null.");
        }

        [Test]
        public void GetFloatsCount_ArrayToSearchIsEmpty_ReturnZeroOccurrences()
        {
            // Arrange
            float[] rangeStart = { 0.1f };
            float[] rangeEnd = { 0.1f };

            // Act
            int actual = FloatCounter.GetFloatsCount(Array.Empty<float>(), rangeStart, rangeEnd);

            // Assert
            Assert.AreEqual(0, actual);
        }

    }
}
