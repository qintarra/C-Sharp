namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            // 5-1. Implement the method that returns true if n is a prime number; otherwise returns false.
            if (n < 2)
            {
                return false;
            }

            uint i = 2;

            while (i * i <= n)
            {
                if (n % i == 0)
                {
                    return false;
                }

                i++;
            }

            return true;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            // 5-2. Implement the method that returns the latest prime number is (0, n] interval.
            while (n >= 2)
            {
                if (IsPrimeNumber(n))
                {
                    return n;
                }

                n--;
            }

            return 0;
        }

    }
}
