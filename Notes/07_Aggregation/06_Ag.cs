using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace OOP_14
{
    abstract class AbstractClass
    {
        public abstract void Method1();
        public void Method2()
        {
            Console.WriteLine("I am a non-abstract method of an abstract class");
        }
    }
    class MyClass : AbstractClass
    {
        public override void Method1()
        {
            Console.WriteLine("I am an overridden method of an abstract class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Method1();
            myClass.Method2();
        }
    }
}