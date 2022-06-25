using System;
namespace OOP_13_2
{
    interface IFirst
    {
        void Method1();
        void Method2();
        void Paint();
    }
    interface ISecond
    {
        void Method3();
        void Paint();
    }
    class ClassDemo : IFirst, ISecond
    {
        public void Method1()
        {
            Console.WriteLine("This is Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("This is Method 2");
        }
        public void Method3()
        {
            Console.WriteLine("This is Method 3");
        }
        public void Paint()
        {
            Console.WriteLine(" :-) ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassDemo obj1 = new ClassDemo();
            Console.WriteLine("Calling methods of the first object");
            obj1.Method1();
            obj1.Method2();
            obj1.Method3();
            obj1.Paint();

            IFirst obj2 = new ClassDemo();
            Console.WriteLine("Calling methods of the second object");
            obj2.Method2();

            ISecond obj3 = new ClassDemo();
            Console.WriteLine("Calling methods of the third object");
            obj3.Method3();
        }
    }
}