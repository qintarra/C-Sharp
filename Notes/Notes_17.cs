using System;
using System.Collections.Generic;
using System.Text;

namespace Notes_17_1
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

using System;
using System.Collections.Generic;
namespace Notes_17_2
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