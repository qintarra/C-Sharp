using System;
namespace OOP_12_2_3
{
    abstract class AbstractClass
    {
        public abstract void Method1();
        public void Method2()
        {
            Console.WriteLine("I am a non-abstract method of the first abstract class");
        }
    }
    abstract class NewAbstractClass : AbstractClass
    {

        public abstract void Method3();
        public void Method4()
        {
            Console.WriteLine("I am a non-abstract method of the second abstract class");
        }
    }
    class MyClass : NewAbstractClass
    {
        public override void Method1()
        {
            Console.WriteLine("I am an overridden method of the first abstract class");
        }
        public override void Method3()
        {
            Console.WriteLine("I am an overridden method of the second abstract class");
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
            myClass.Method4();
        }
    }
}
