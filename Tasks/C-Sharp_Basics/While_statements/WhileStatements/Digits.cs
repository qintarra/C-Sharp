namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            // 4-1. Implement the method that returns sum of digits of a number.
            return (n / 100) + ((n / 10) % 10) + (n % 10);
        }
    }
}
