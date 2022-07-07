using System;
namespace Delegate_1
{
    class Program
    {
        delegate void Mydelegate(string s);
        static void Method(string s)
        {
            Console.WriteLine(s);
        }


        static void Main(string[] args)
        {
            Mydelegate del = new Mydelegate(Method);
            del("How long");

            // second option
            Mydelegate del2 = Method;
            del2("How long will I slide?");
        }
    }
}