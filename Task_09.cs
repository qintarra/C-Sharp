using System;

namespace Task

{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                try
                {
                    Console.WriteLine("Enter first number");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error. Enter numbers");
                    Console.ReadLine();
                    continue;
                }
                
                Console.WriteLine("Select operation: '+', '-', '*', '/'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                        {
                            Console.WriteLine("Zero Division Error");
                        }
                        else
                        {
                            Console.WriteLine(firstValue / secondValue);
                        }
                        break;
                    default:
                        Console.WriteLine("Error. Unknown Action.");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}