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

        [TestCase("Deposit", "Income", typeof(decimal))]
        [TestCase("BaseDeposit", "Income", typeof(decimal))]
        [TestCase("SpecialDeposit", "Income", typeof(decimal))]
        [TestCase("LongDeposit", "Income", typeof(decimal))]
        [TestCase("Client", "AddDeposit", typeof(bool))]
        [TestCase("Client", "TotalIncome", typeof(decimal))]
        [TestCase("Client", "MaxIncome", typeof(decimal))]
        [TestCase("Client", "GetIncomeByNumber", typeof(decimal))]
        public void Class_HasMethodsWithCorrectSignatures(string className, string methodName, Type returnType)
        {
            var classType = Type.GetType($"{AssemblyName}.{className}, {AssemblyName}");
            AssertFailIfNull(classType, $"Class '{className}'");

            var methodType = classType.GetMethod(methodName);
            AssertFailIfNull(methodType, $"Method '{methodName}'");

            if (methodType.ReturnType != returnType)
            {
                Assert.Fail($"Class '{className}' doesn't have method with name '{methodName}' that returns '{returnType}'.");
            }
        }

        [Test]
        public void Deposit_HasAbstractMethodIncome()
        {
            var classType = Type.GetType($"{AssemblyName}.Deposit, {AssemblyName}");
            AssertFailIfNull(classType, $"Class 'Deposit'");

            var methodType = classType.GetMethod("Income");
            AssertFailIfNull(methodType, $"Method 'Income'");

            if (!methodType.IsAbstract)
            {
                Assert.Fail("Method 'Income' is not abstract.");
            }
        }

    }
}
