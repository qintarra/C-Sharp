using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_11
{
	class A
    {
        public A()
        {
            //Instance of Class A created
            Console.WriteLine("Class A constuctor called");
        }
    }
    class B : A
    {
        public B()
        {
            //Instance of Class B created
            Console.WriteLine("Class B constuctor called");
        }
    }
    class C : B
    {
        public C()
        {
            //Instance of Class C created
            Console.WriteLine("Class C constuctor called");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
        }
    }
}