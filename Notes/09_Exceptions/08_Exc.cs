using System;
namespace Exception8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    int a = int.Parse("0");
                    int b = 10 / a;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error handling in a indoor block");
                    int c = int.Parse("10000000000");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error handling in an external block");
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}