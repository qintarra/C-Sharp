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

        [TestCase("Employee", "name", typeof(string))]
        [TestCase("Employee", "salary", typeof(decimal))]
        [TestCase("Employee", "bonus", typeof(decimal))]
        [TestCase("Manager", "quantity", typeof(int))]
        [TestCase("SalesPerson", "percent", typeof(int))]
        public void FieldExist(string className, string fieldName, Type fieldType)
        {
            var classType = GetClass(className);
            var field = classType.GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.Multiple(() =>
            {
                Assert.That(field, Is.Not.Null);
                Assert.That(field.FieldType, Is.EqualTo(fieldType));
            });
        }

    }
}

