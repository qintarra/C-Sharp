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

        [TestCase("Employee", "Name", typeof(string), false)]
        [TestCase("Employee", "Salary", typeof(decimal), true)]
        public void PropertyExist(string className, string propertyName, Type propertyType, bool isWriteable,
            bool isReadable = true)
        {
            var classType = GetClass(className);
            var property = classType.GetProperty(propertyName);
            Assert.Multiple(() =>
            {
                Assert.That(property, Is.Not.Null);
                Assert.That(property.PropertyType, Is.EqualTo(propertyType));
                Assert.That(property.CanRead, Is.EqualTo(isReadable));
                Assert.That(property.CanWrite, Is.EqualTo(isWriteable));
            });
        }

    }
}

