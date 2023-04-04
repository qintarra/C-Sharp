using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomArray.Tests
{
    [TestFixture]
    public class Tests
    {       
        [Test()]
        public void Array_Get_ShouldReturnSameReference()
        {
            //arrange
            var array = new int[] { 1, 2, 3, 4 };
            int first = -5;
            //act
            var custom = new CustomArray<int>(first, array);
            //assert
            Assert.AreSame(array, custom.Array, message: "Array property works incorrectly");
        }

        [Test]
        public void Array_Get_WithListShouldRetrurnSameReference()
        {
            var expected_list = new List<int>() { 6, 2, -8, 0 };
            int first = 4;

            var custom = new CustomArray<int>(first, expected_list);
            var actual_array = custom.Array;

            Assert.AreEqual(expected_list, actual_array, message: "Array property or constructor works incorrectly");

        }

        [TestCase(-4, 5, -3, 10)]
        [TestCase(1, 7, 2, 4)]
        [TestCase(0, 3, 2, 9)]
        public void Indexer_GetElementAtPosition_ShouldReturnValue(int first, int length, int n, int element)
        {
            //Act
            var custom = new CustomArray<int>(first, length);
            custom[n] = element;
            //Assert
            Assert.AreEqual(element, custom[n], message: "Index get property works incorrectly");

        }
		
        [TestCase(-1, 6)]
        [TestCase(0, 7)]
        [TestCase(5, 2)]
        public void Length_Get_ShouldReturnCorrectValue(int first, int length)
        {
            // Act
            var custom = new CustomArray<string>(first, length);
            //Assert
            Assert.AreEqual(length, custom.Length, message: "Length get  property works incorrectly ");
        }
		
        [TestCase(-1, 5)]
        [TestCase(0, 11)]
        [TestCase(7, 3)]
        public void First_Get_ShouldReturnCorrectValue(int first, int length)
        {
            // Act
            var custom = new CustomArray<int>(first, length);

            //Assert
            Assert.AreEqual(first, custom.First, message: "First get property works incorrectly ");
        }
		
        [TestCase(-8, 4, -5)]
        [TestCase(0, 8, 7)]
        [TestCase(3, 5, 7)]
        public void Last_Get_ShouldReturnCorrectValue(int first, int length, int last)
        {
            //Act
            var custom = new CustomArray<bool>(first, length);

            //Assert
            Assert.AreEqual(last, custom.Last, message: "Last get property works incorrectly ");

        }
		
        [Test]
        public void CustomArrayProperties_Get_ShouldReturnCorrectValues()
        {
            //Arrange
            int first = 4;
            int length = 4;
            int last = 7;

            //Act
            var custom = new CustomArray<int>(first, 5, 7, 3, 7);
            //Assert
            Assert.AreEqual(first, custom.First, message: "First get property works incorrectly");
            Assert.AreEqual(length, custom.Length, message: "Length get property works incorrectly");
            Assert.AreEqual(last, custom.Last, message: "Last get property works incorrectly");

        }

    }
}
