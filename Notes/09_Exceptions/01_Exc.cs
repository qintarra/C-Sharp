using System;
namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first integer");
                int i = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second integer");
                int j = Int32.Parse(Console.ReadLine());
                int k = i / j;
                Console.WriteLine("The result of dividing {0} by {1} is {2}", i, j, k);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0} ", e.Message);
            }
        }
    }
}