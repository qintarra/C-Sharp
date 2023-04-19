using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Inheritance.Tests
{
    [TestFixture]
    public class InheritanceTests
    {
        #region low

        [TestCase("Employee")]
        [TestCase("Manager")]
        [TestCase("SalesPerson")]
        public void ClassExist(string className)
        {
            GetClass(className);
        }

    }
}

