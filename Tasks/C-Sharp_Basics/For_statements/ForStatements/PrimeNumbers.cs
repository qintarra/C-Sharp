namespace ForStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            // Task 15. Implement the method that returns true if n is a prime number; otherwise returns false.
            if (n < 2)
            {
                return false;
            }

            for (uint i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static ulong SumDigitsOfPrimeNumbers(int start, int end)
        {
            // Task 16. Implement the method that returns the sum of digits of all prime numbers in the [start, end] interval.
            ulong sum = 0;

            for (int i = start; i <= end; i++)
            {
                if (!IsPrimeNumber((uint)i))
                {
                    continue;
                }

                for (int num = i; num > 0;)
                {
                    sum += (ulong)(num % 10);
                    num /= 10;
                }
            }

            return sum;
        }
    }
}
