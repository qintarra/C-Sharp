using System;
namespace Exception4
{
    class DivisionException : Exception
    {
        public int X { get; }
        public int Y { get; }
        public override string Message
        {
            get
            {
                return "Invalid division operation";
            }
        }
        public DivisionException(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
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
                if (i % j != 0)
                {
                    throw new DivisionException(i, j);
                }
                int k = i / j;
                Console.WriteLine("The result of dividing {0} by {1} is {2}", i, j, k);
            }
            catch (DivisionException e)
            {
                Console.WriteLine("Exception: {0} ", e.Message);
                Console.WriteLine("The number {0} is not divisible by {1}", e.X, e.Y);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0} ", e.Message);
            }
        }
    }
}