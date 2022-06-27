using System;
namespace Exception2
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
            catch (FormatException)
            {
                Console.WriteLine("Invalid input data format");
                Console.WriteLine("The input string contains other characters in addition to numbers");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow");
                Console.WriteLine("Number greater than {0}", int.MaxValue);
                //Environment.Exit(1);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero");
            }
            catch (Exception)
            {
                Console.WriteLine("Unrecognized exception");
            }
            finally
            {
                Console.WriteLine("Hooray! The program has ended!!!");
            }
        }
    }
}