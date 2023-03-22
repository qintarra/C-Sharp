namespace ForStatements
{
    public static class FibonacciSequence
    {
        public static int GetFibonacciNumber(int n)
        {
            // Task 9. Implement the method that returns a Fibonacci sequence number.  
            int current = 0;
            int next = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = current;
                current = next;
                next = temp + next;
            }

            return current;
        }

        public static ulong GetProductOfFibonacciNumberDigits(ulong n)
        {
            // Task 10. Implement the method that returns the product of digits of the Fibonacci sequence number.  
            int fibonacci = GetFibonacciNumber((int)n);
            int product = 1;

            if (n == 0)
            {
                return 0;
            }

            for (int i = fibonacci; i > 0; i /= 10)
            {
                int digit = i % 10;
                product *= digit;
            }

            return (ulong)product;
        }
    }
}
