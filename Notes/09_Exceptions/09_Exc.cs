using System;
namespace Exception9
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
                catch (Exception e)
                {
                    Console.WriteLine("Error handling in a indoor block");
                    throw new Exception("Error handling error", e);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error handling in an external block");
                Console.WriteLine("Message: {0}", e.Message);
                // Property InnerException gets the Exception instance that caused the current exception.
                if (e.InnerException != null)
                {
                    Console.WriteLine("Exception instance that caused the current exception: { 0}", e.InnerException.Message);
                    Console.WriteLine("Previous error type: {0}", e.InnerException.GetType());
                }
            }
        }
    }
}