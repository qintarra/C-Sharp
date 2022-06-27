using System;
namespace Exception7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    int a = int.Parse("O");
                    int b = 10 / a;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error handling in a indoor block");
                    int c = int.Parse("10000000000");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error handling in an external block");
            }
        }
    }
}