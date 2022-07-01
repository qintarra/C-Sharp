using System;
namespace ExtensionMethods_7
{
    public interface IMyInterface
    {
        // Any class that implements IMyInterface must implement a method,
        // declared in the interface
        void MethodB();
    }
    public static class Extension
    {
        // The static class Extensions contain extension methods,
        // defined for any type that implements the IMyInterface interface.
        // All three classes - A, B, and C - implement this interface.
        public static void MethodA(this IMyInterface myInterface, int i)
        {
            Console.WriteLine("Extension MethodA with int parameter");
        }
        public static void MethodA(this IMyInterface myInterface, string s)
        {
            Console.WriteLine("Extension MethodA with string parameter");
        }

        public static void MethodB(this IMyInterface myInterface)
        {
            Console.WriteLine("Extension method MethodB without parameters");
        }
    }
    class A : IMyInterface
    {
        public void MethodB() { Console.WriteLine("A.MethodB()"); }
    }
    class B : IMyInterface
    {
        public void MethodB() { Console.WriteLine("B.MethodB()"); }
        public void MethodA(int i) { Console.WriteLine("B.MethodA(int i)"); }
    }
    class C : IMyInterface
    {
        public void MethodB() { Console.WriteLine("C.MethodB()"); }
        public void MethodA(object obj)
        {
            Console.WriteLine("C.MethodA(object obj)");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an instance of class A, class B, and class C.
            A a = new A();
            B b = new B();
            C c = new C();
            // For a, b, and c, call the following methods:
            // -- MethodA with an int argument
            // -- MethodA with a string argument
            // -- MethodB with no argument.
            //a.MethodA(1);
            //a.MethodA("hello");
            //a.MethodB();
            //b.MethodA(1);
            //b.MethodA("hello");
            //b.MethodB();
            c.MethodA(1);
            c.MethodA("hello");
            c.MethodB();
            /* The extension method MethodB () is never called because its name and signature
             * are exactly the same as those already implemented in these classes.
             * If the compiler cannot find an instance method with the same signature,
             * it binds to the appropriate extension method, if one exists.
             */
        }
    }
}