using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Struct_via_Class
{
    class MyClass
    {
        public int x;
    }

    struct MyStruct
    {
        public int x;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a billion instances of the structure");
            DateTime start = DateTime.Now;
            for (int i = 0; i < 1000000000; i++)
            {
                MyStruct m;
                m.x = 10;
                int q = m.x;
            }
            DateTime finish = DateTime.Now;
            long x = finish.Ticks - start.Ticks;
            Console.WriteLine("OK");
            Console.WriteLine(x);
            Console.WriteLine(DateTime.FromBinary(x).ToLongTimeString());

            Console.WriteLine("Create a billion instances of the structure");
            start = DateTime.Now;
            for (int i = 0; i < 1000000000; i++)
            {
                MyClass m = new MyClass();
                m.x = 10;
                int q = m.x;
            }
            finish = DateTime.Now;
            x = finish.Ticks - start.Ticks;
            Console.WriteLine("OK");
            Console.WriteLine(x); Console.WriteLine(DateTime.FromBinary(x).ToLongTimeString());
        }
    }
}