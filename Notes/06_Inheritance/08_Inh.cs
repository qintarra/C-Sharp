using System;
using System.Collections.Generic;

namespace OOP_11n
{
    class A
    {
        private int x;

        public A(int x)
        {
            this.x = x;
        }
        public void Print()
        {
            Console.WriteLine(x);
        }
    }
    class B : A
    {
        public B(int x):base (x)
        {
            x = 1;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            B b = new B(4);
            b.Print();
        }
    }
}