using System;
namespace Delegate_4
{
    delegate void Del(string s);

    class Program
    {
        static void Hello(string s)
        {
            Console.WriteLine(" Hello, {0}!", s);
        }
        static void Goodbye(string s)
        {
            Console.WriteLine(" Goodbye, {0}!", s);
        }
        static void Main()
        {
            Del a, b, c, d;
            // Create the delegate object 'a' that references
            // the method 'Hello':
            a = Hello;
            // Create the delegate object 'b' that references
            // the method 'Goodbye':
            b = Goodbye;
            // Two delegates, 'a' and 'b', are composed to form 'c':
            c = a + b;
            //c = Hello;
            c += Goodbye;
            // Remove 'a' from the composed delegate, leaving 'd',
            // which calls only the method 'Goodbye':
            d = c - a;
            Console.WriteLine("Delegate a is called:");
            a("A");
            Console.WriteLine("Delegate b is called:");
            b("B");
            Console.WriteLine("Delegate c is called:");
            c("C");
            Console.WriteLine("Delegate d is called:");
            d("D");
        }
    }
}