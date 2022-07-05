using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Method_4
{
    //Out modifier
    //To make a parameter output, 'out' modifier is placed in front of it
    class Program
    {
        static void Sum(int x, int y, out int a)
        {
            a = x + y;
        }

        static void Main(string [] args)
        {
            int c = 11, d = 16;
            int z;
            Sum(c, d, out z);
            Console.WriteLine(z);
        }
    }
}