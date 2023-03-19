using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace Interfaces.Tests
{
    [TestFixture]
    public class Tests
    {
        const string AssemblyName = "Interfaces";

        private void AssertFailIfNull(object obj, string message)
        {
            if (obj == null)
            {
                Assert.Fail($"{message} doesn't exist");
            }
        }

        private Type GetCustomType(string name, string message)
        {
            var type = Type.GetType($"{AssemblyName}.{name}, {AssemblyName}");
            AssertFailIfNull(type, message);
            return type;
        }

    }
}
