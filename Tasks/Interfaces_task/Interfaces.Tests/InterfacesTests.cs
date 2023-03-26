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

        [TestCase("Deposit", "Amount", typeof(decimal))]
        [TestCase("BaseDeposit", "Amount", typeof(decimal))]
        [TestCase("SpecialDeposit", "Amount", typeof(decimal))]
        [TestCase("LongDeposit", "Amount", typeof(decimal))]
        [TestCase("Deposit", "Period", typeof(int))]
        [TestCase("BaseDeposit", "Period", typeof(int))]
        [TestCase("SpecialDeposit", "Period", typeof(int))]
        [TestCase("LongDeposit", "Period", typeof(int))]
        public void Class_HasPublicReadonlyFieldWithType(string className, string fieldName, Type returnType)
        {
            var classType = Type.GetType($"{AssemblyName}.{className}, {AssemblyName}");
            AssertFailIfNull(classType, $"Class {className}");

            var propertyInfo = classType.GetProperty(fieldName, BindingFlags.Public | BindingFlags.Instance);
            AssertFailIfNull(propertyInfo, $"Field '{fieldName}'");

            if (!propertyInfo.CanRead && propertyInfo.CanWrite && propertyInfo.PropertyType != returnType)
            {
                Assert.Fail($"{className} doesn't have public readonly property {fieldName} with {returnType} return type.");
            }
        }

        [Test]
        public void Client_HasPrivatePropertyDeposits()
        {
            var client = GetCustomType("Client", "Class 'Client'");
            var deposit = GetCustomType("Deposit", "Class 'Deposit'");

            var fieldType = client.GetField("deposits", BindingFlags.NonPublic | BindingFlags.Instance);
            AssertFailIfNull(fieldType, "Field 'deposits'");

            var arrayOfDeposits = Array.CreateInstance(deposit, 10).GetType();

            if (!fieldType.IsPrivate && fieldType.FieldType != arrayOfDeposits)
            {
                Assert.Fail("Property 'deposits' in class 'Client' is incorrect.");
            }
        }

        [Test]
        public void Client_ConstructorCreatesArrayOfDepositsWithSize10()
        {
            var client = GetCustomType("Client", "Class 'Client'");
            var deposit = GetCustomType("Deposit", "Class 'Deposit'");

            var fieldType = client.GetField("deposits", BindingFlags.NonPublic | BindingFlags.Instance);
            AssertFailIfNull(fieldType, "Field 'deposits'");

            var constructor = client.GetConstructor(Type.EmptyTypes);
            AssertFailIfNull(constructor, "Constructor of 'Client'");

            var invokedConstructor = constructor.Invoke(Type.EmptyTypes);
            var depositsField = (Array)fieldType.GetValue(invokedConstructor);
            AssertFailIfNull(depositsField, "Field 'deposits'");
            var arrayOfDeposits = Array.CreateInstance(deposit, 10);

            if (depositsField.Length != 10)
            {
                Assert.Fail("Property 'deposits' must be of type array of deposits with length 10.");
            }

            for (int i = 0; i < depositsField.Length; i++)
            {
                if (depositsField.GetValue(i) != arrayOfDeposits.GetValue(i))
                {
                    Assert.Fail("Constructor in class 'Client' works incorrectly.");
                }
            }
        }

        [TestCase("Deposit", typeof(decimal), typeof(int))]
        [TestCase("BaseDeposit", typeof(decimal), typeof(int))]
        [TestCase("SpecialDeposit", typeof(decimal), typeof(int))]
        [TestCase("LongDeposit", typeof(decimal), typeof(int))]
        [TestCase("Client")]
        public void Class_DoesHaveConstructor(string className, params Type[] parameters)
        {
            var type = Type.GetType($"{AssemblyName}.{className}, {AssemblyName}");

            AssertFailIfNull(type, $"Class '{className}'");

            var constructor = type.GetConstructor(parameters);

            if (constructor == null && !constructor.IsPublic)
            {
                Assert.Fail($"Class {className} has invalid constructor.");
            }
        }
        
        [TestCase(1, "BaseDeposit", typeof(decimal), typeof(int))]
        [TestCase(5, "LongDeposit", typeof(decimal), typeof(int))]
        [TestCase(7, "SpecialDeposit", typeof(decimal), typeof(int))]
        [TestCase(0, "BaseDeposit", typeof(decimal), typeof(int))]
        public void Client_AddDeposit_AddsObjectToFirstFreePlace(int addCount, string className, params Type[] parameters)
        {
            var clientType = GetCustomType("Client", "Class 'Client'");
            var deposit = GetCustomType(className, $"Class '{className}'");

            var clientObject = Activator.CreateInstance(clientType);
            
            var constructor = deposit.GetConstructor(parameters);
            AssertFailIfNull(constructor, $"Constructor in class '{className}'");

            if (constructor == null && !constructor.IsPublic)
            {
                Assert.Fail($"Constructor of class '{className}' doesn't exist.");
            }
            var depositObject = Activator.CreateInstance(deposit, 1000m, 1);

            var depositField = clientType.GetField("deposits", BindingFlags.NonPublic | BindingFlags.Instance);
            AssertFailIfNull(depositField, "Field 'deposits'");

            var method = clientType.GetMethod("AddDeposit");
            AssertFailIfNull(method, "Method 'AddDeposit'");

            for (int i = 0; i < addCount; i++)
            {
                method.Invoke(clientObject, new object[] {depositObject});
            }

            var objArray = (Array) depositField.GetValue(clientObject);
            var array = Array.CreateInstance(deposit, 10);
            Array.Copy(objArray, array, 10);

            for (int i = 0; i < array.Length; i++)
            {
                if ((i < addCount && array.GetValue(i) == null)
                    || (i > addCount && array.GetValue(i) != null))
                {
                    Assert.Fail("Method 'AddDeposit' in class 'Client' works incorrectly.");
                }
            }
        }

        [TestCase("BaseDeposit")]
        [TestCase("LongDeposit")]
        [TestCase("SpecialDeposit")]
        [TestCase("BaseDeposit")]
        public void Client_AddDeposit_ReturnsTrueIfArrayHasFreePlace(string className)
        {
            //arrange
            var clientType = GetCustomType("Client", "Class 'Client'");
            var deposit = GetCustomType(className, $"Class '{className}'");

            var clientObject = Activator.CreateInstance(clientType);
            var depositObject = Activator.CreateInstance(deposit, 1000m, 1);

            var method = clientType.GetMethod("AddDeposit");
            AssertFailIfNull(method, "Method 'AddDeposit'");

            //act
            var hasFreePlace = (bool) method.Invoke(clientObject, new object[] {depositObject});

            //assert
            if (!hasFreePlace)
            {
                Assert.Fail("Method 'AddDeposit' in class 'Client' works incorrectly.");
            }
        }

    }
}
