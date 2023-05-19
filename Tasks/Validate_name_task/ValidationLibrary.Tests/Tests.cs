using NUnit.Framework;
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

    }
}
