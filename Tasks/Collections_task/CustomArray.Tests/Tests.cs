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

  
    }
}
