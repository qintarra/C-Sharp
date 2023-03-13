namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            // 4-1. Implement the method that returns sum of digits of a number.
            return (n / 100) + ((n / 10) % 10) + (n % 10);
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            // 4-2. Implement the method that returns product of digits of a number.
            if (n == ulong.MinValue)
            {
                return 0;
            }

            ulong product = 1;
            while (n > 0)
            {
                product *= n % 10;
                n /= 10;
            }

            return product;
        }
    }
}
