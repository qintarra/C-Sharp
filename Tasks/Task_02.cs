using System;
namespace Task02
{
    //Enter 3 numbers and display the value of the sum and product of these numbers
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Enter 1st number");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter 3rd number");

            thirdValue = double.Parse(Console.ReadLine());

            double sumResult = firstValue + secondValue + thirdValue;

            double prodResult = firstValue * secondValue * thirdValue;

            Console.WriteLine("Sum of three numbers = " + sumResult);

            Console.WriteLine("Product of three numbers = " + prodResult);
        }
    }
}