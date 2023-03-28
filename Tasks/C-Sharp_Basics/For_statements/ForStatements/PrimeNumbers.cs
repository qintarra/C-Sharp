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

        }
    }
}
