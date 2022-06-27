using System;
namespace Exception6
{
    [Serializable]
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
        public DivisionException() { }
        public DivisionException(string message) : base(message) { }
        public DivisionException(string message, Exception innerException) : base(message, innerException)
        { }
        protected DivisionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
        public DivisionException(int x, int y)
        {
            X = x;
            Y = y;
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
                if (j == 0 || i % j != 0 || j < 0)
                {
                    throw new DivisionException(i, j);
                }
                int k = i / j;
                Console.WriteLine("The result of dividing {0} by {1} is {2}", i, j, k);
            }
            catch (DivisionException e) when (e.Y == 0)
            {
                Console.WriteLine("Exception: {0} ", e.Message);
                Console.WriteLine("You cannot divide by zero!!!!");
            }
            catch (DivisionException e) when (e.Y < 0)
            {
                Console.WriteLine("Exception: {0} ", e.Message);
                Console.WriteLine("Divisor cannot be negative!");
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