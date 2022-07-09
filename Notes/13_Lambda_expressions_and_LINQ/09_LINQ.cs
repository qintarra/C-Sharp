using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate the number of positive paired array elements
            // whose value is less than 10
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, -2, 12, 14, 2 };
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] < 10)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);

            // LINQ - Language Integrated Query

            // Query syntax (similar to SQL queries)
            count = (from n in numbers
                     where n > 0
                     where n % 2 == 0
                     where n < 10
                     select n).Count();
            Console.WriteLine(count);

            // Method Syntax (aka fluent syntax):
            // query building syntax that uses extension methods and lambda expressions

            count = numbers
            .Where(n => n > 0)
            .Where(n => n % 2 == 0)
            .Count(n => n < 10);

            // The fluent syntax allows chaining query operations
            // Can be done in one line:
            // count = numbers.Where(n => n > 0).Where(n => n % 2 == 0).Count(n => n < 10);
            Console.WriteLine(count);
        }
    }
}