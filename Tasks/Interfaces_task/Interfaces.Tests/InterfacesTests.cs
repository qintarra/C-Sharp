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

        [TestCase("BaseDeposit", 1000, 0, 0)]
        [TestCase("BaseDeposit", 1000, 1, 50)]
        [TestCase("BaseDeposit", 1000, 2, 102.5)]
        [TestCase("BaseDeposit", 1000, 3, 157.625)]
        [TestCase("SpecialDeposit", 1000, 0, 0)]
        [TestCase("SpecialDeposit", 1000, 1, 10)]
        [TestCase("SpecialDeposit", 1000, 2, 30.2)]
        [TestCase("SpecialDeposit", 1000, 3, 61.106)]
        [TestCase("LongDeposit", 1000, 0, 0)]
        [TestCase("LongDeposit", 1000, 1, 0)]
        [TestCase("LongDeposit", 1000, 6, 0)]
        [TestCase("LongDeposit", 1000, 7, 150)]
        [TestCase("LongDeposit", 1000, 8, 322.5)]
        public void Class_Income_WorksCorrectly(string className, decimal summ, int period, decimal expectedAmountAfterPeriod)
        {
            var type = Type.GetType($"{AssemblyName}.{className}, {AssemblyName}");
            decimal precision = 0.01m;
            AssertFailIfNull(type, $"Class '{className}'");

            var income = type.GetMethod("Income");
            AssertFailIfNull(income, "Method 'Income'");

            var deposit = Activator.CreateInstance(type, summ, period);

            if (Math.Abs(expectedAmountAfterPeriod - (decimal)income.Invoke(deposit, null)) > precision)
            {
                Assert.Fail($"Method 'Income' in {className} class works incorrectly.");
            }
        }

        [Test]
        public void Deposit_IsAbstractClassOrExists()
        {
            var type = Type.GetType($"{AssemblyName}.Deposit, {AssemblyName}");

            AssertFailIfNull(type, "Class 'Deposit'");

            if (!type.IsAbstract)
            {
                Assert.Fail("Class 'Deposit' is not abstract.");
            }
        }

        [TestCase("Deposit")]
        [TestCase("BaseDeposit")]
        [TestCase("SpecialDeposit")]
        [TestCase("LongDeposit")]
        [TestCase("Client")]
        public void Class_IsClassExists(string className)
        {
            var type = Type.GetType($"{AssemblyName}.{className}, {AssemblyName}");

            AssertFailIfNull(type, $"Class '{className}'");
        }

        [TestCase("Deposit", "BaseDeposit")]
        [TestCase("Deposit", "SpecialDeposit")]
        [TestCase("Deposit", "LongDeposit")]
        public void Class_IsClassInheritsFromClass(string parentClassName, string childClassName)
        {
            var parentType = Type.GetType($"{AssemblyName}.{parentClassName}, {AssemblyName}");
            var childType = Type.GetType($"{AssemblyName}.{childClassName}, {AssemblyName}");

            AssertFailIfNull(parentType, $"Class '{parentClassName}'");
            AssertFailIfNull(childType, $"Class '{childClassName}'");

            if (!parentType.IsAbstract && !childType.IsSubclassOf(parentType))
            {
                Assert.Fail($"Class '{childType}' doesn't inherit from '{parentType}'");
            }
        }

    }
}
