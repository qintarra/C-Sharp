using System;
namespace Task01
{
    //Calculate the arithmetic mean of two numbers
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;

            Console.WriteLine("Enter 1st number");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");

            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;

            Console.WriteLine("The arithmetic mean of your numbers is " + result);
        }
    }
}