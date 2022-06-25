using System;
namespace OOP_13_7
{
    interface IFirst
    {
        void Method1();
    }
    abstract class AbstractClass : IFirst
    {
        public void Method1()
        {
            Console.WriteLine("This is Method 1");
        }
        public abstract void Method2();
        public void Method3()
        {
            Console.WriteLine("I am a non-abstract method of an abstract class");
        }
    }
    class MyClass : AbstractClass
    {
        public override void Method2()
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
            myClass.Method3();
        }
    }
}