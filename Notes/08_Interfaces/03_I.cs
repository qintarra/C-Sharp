using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OOP_31
{
    interface IFirst
    {
        void Method();
    }
    interface ISecond
    {
        void Method();
    }
    class MyClass : IFirst, ISecond
    {
        public void Method()
        {
            Console.WriteLine("Common overridden method called");
        }
        void IFirst.Method()
        {
            Console.WriteLine("Overridden method of first interface called");
        }
        void ISecond.Method()
        {
            Console.WriteLine("Overridden method of second interface called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc1 = new MyClass();
            mc1.Method();
            IFirst mc2 = mc1 as IFirst;
            mc2.Method();
            ISecond mc3 = new MyClass();
            mc3.Method();

        }
    }
}