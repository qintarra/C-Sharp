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

using System;
using System.Collections.Generic;

namespace Notes_17_3
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7_5
{
    class Person
    {
        protected string firstname;
        protected string lastname;
        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public void AboutMe()
        {
            Console.WriteLine($"My name is {firstname} {lastname}.");
        }
    }
    class Student : Person
    {
        private string university;
        public Student(string firstname, string lastname, string university):base(firstname, lastname)
        {
            this.university = university;
        }
        public new void AboutMe()
        {
            Console.WriteLine($"I'm {firstname} {lastname}, student of {university}.");
        }
    }
    class Driver : Person
    {
        public string auto;
        public Driver(string firstname, string lastname, string auto) : base(firstname, lastname)
        {
            this.auto = auto;
        }
        public new void AboutMe()
        {
            Console.WriteLine($"I'm {firstname} {lastname}, driver of {auto}.");
        }
    }
   
    
}
