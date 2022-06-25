using System;
namespace OOP_13_6
{
    interface IFirst
    {
        void Method1();
    }
    interface ISecond : IFirst
    {
        void Method2();
    }
    class ClassDemo : ISecond
    {
        public void Method1()
        {
            Console.WriteLine("This is Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("This is Method 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassDemo obj1 = new ClassDemo();
            Console.WriteLine("Calling object methods");
            obj1.Method1();
            obj1.Method2();
        }
    }
}