using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lambda_expression_4_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            // The standard Action <> delegate encapsulates a method that takes 1 to 16 parameters
            // and does not return a value.
            Action<string> PrintString;
            PrintString = s => Console.WriteLine(s);
            PrintString("Hello, World!");

            Action<int, int> PrintSumm;
            PrintSumm = (x, y) => Console.WriteLine(x + y);
            PrintSumm(2, 3);

            Action<string, int> AboutMe;
            AboutMe = (name, age) => Console.WriteLine($"My name is {name} and I am {age} years old ");
            AboutMe("Travis", 25);
        }
    }
}