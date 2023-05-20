﻿using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;

namespace ValidationLibrary.Tests
{
    [TestFixture]
    public class Tests
    {
        private Type type;
        private Type paramType;
        private string methodName;

        [SetUp]
        public void Initial()
        {
            type = Type.GetType("ValidationLibrary.StringOperation, ValidationLibrary", false, true);
            paramType = typeof(string);
            methodName = "GetValidName";
        }

        #region Reflection
        [Test]
        public void GetValidNameMethod_WithRightSignatureAndParameter_IsExist()
        {
            //arrange
            string parameter = "nameToValidate";

            //act
            var actualMethod = GetMethod(methodName);

            var actualParameter = actualMethod.GetParameters().FirstOrDefault();
            if (actualParameter is null)
            {
                Assert.Fail("GetValidName method doesn't has any parameter");
            }
            if (actualParameter.Name != parameter)
            {
                Assert.Fail("GetValidName method doesn't has parameter of  'nameToValidate' name ");
            }
            if (actualParameter.ParameterType != paramType)
            {
                Assert.Fail("GetValidName method doesn't has parameter of string type ");
            }
        }

        #endregion

        #region Invoke

        [TestCase("hello world 2020year ^rt", 19)]
        [TestCase("<(￣︶￣)> ＼(＾▽＾)／ (o_O)", 2)]
        [TestCase("Dmy$tro   /Ponasenkov", 17)]
        public void GetValidName_WithInputString_ReturnStringOfCorrectLength(string input, int expected_length)
        {
            //act
            var actualMethod = GetMethod(methodName);
            var actualLength = ((string)actualMethod.Invoke(type, new object[] { input })).Length;

            //assert
            Assert.AreEqual(expected_length, actualLength
                , message: "GetValidName return string of incorrect length");
        }

        [TestCase("voLodYmyr KlyCHko", "Volodymyr Klychko")]
        [TestCase("marshall mathers", "Marshall Mathers")]
        [TestCase("Nice Person", "Nice Person")]
        [TestCase("NICK COPELAND", "Nick Copeland")]
        public void GetValidName_ReturnStringInRightRegister(string input, string expected)
        {
            //
            //act 
            var actualMethod = GetMethod(methodName);
            var actual = actualMethod.Invoke(type, new object[] { input });

            //assert
            Assert.AreEqual(expected, actual
                , message: "Case sensitivity logic in GetValidName method works incorrect");

        }


        #endregion

        
    }
}
