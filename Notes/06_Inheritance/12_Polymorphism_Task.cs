using System;

namespace Polymorphism_Task
{
    class A
    {
        public virtual void M()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        public override void M()
        {
            Console.WriteLine("B");
        }
    }
    class C : B
    {
        public new virtual void M()
        {
            Console.WriteLine("C");
        }
    }
    class D : C
    {
        public override void M()
        {
            Console.WriteLine("D");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            C c = d;
            B b = d;
            A a = d;
            d.M();
            c.M();
            b.M();
            a.M();
        }
    }
}