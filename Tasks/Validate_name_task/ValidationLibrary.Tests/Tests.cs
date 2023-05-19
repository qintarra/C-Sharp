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

    }
}
