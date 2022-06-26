using System;
namespace OOP_13_8
{
    interface IFirst
    {
        void Method1();
    }
    abstract class AbstractClass : IFirst
    {
        public abstract void Method1();
        public abstract void Method2();
        public void Method3()
        {
            Console.WriteLine("I am a non -abstract method of an abstract class");
        }
        void IFirst.Method1()
        {
            Console.WriteLine("I am a interface method implemented in an abstract class");
        }
    }
    class MyClass : AbstractClass
    {
        public override void Method1()
        {
            Console.WriteLine("I am the first overridden method of an abstract class");
        }
        public override void Method2()
        {
            Console.WriteLine("I am the second overridden method of the abstract class");
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
            ((myClass as AbstractClass) as IFirst).Method1();
        }
    }
}