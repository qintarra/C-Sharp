using System;
using System.Collections.Generic;

namespace OOP_11_2
{
    class A
    {
        int a;
        public A()
        {
            a = 1;
        }
        public void Print()
        {
            Console.Write($"a = {a} ");
        }
    }
    class B : A
    {
        int b;
        public B()
        {
            b = 2;
        }
        public new void Print()
        {
            base.Print();
            Console.Write($"b = {b} ");
        }
    }
    class C : B
    {
        int c;
        public C()
        {
            c = 3;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"c = {c} ");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            C c = new C();
            c.Print();
            (c as B).Print();
            Console.WriteLine();
            (c as A).Print();
            Console.WriteLine();
        }
    }
}