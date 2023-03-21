namespace ForStatements
{
    public static class Factorial
    {
        public static int GetFactorial(int n)
        {
            // Task 4. Implement the method that returns the factorial of the number n! using the for statement.
            int factorial = 1;

            if (n == 0)
            {
                return factorial;
            }

            for (int i = 1; i < n; i++)
            {
                factorial *= i;
            }

            return n * factorial;
        }

        public static int SumFactorialDigits(int n)
        {
            // Task 5. Implement the method that calculates the factorial of the number n! and returns the sum of its digits using the for statement.
            int factorial = GetFactorial(n);
            int sum = 0;

            for (int i = factorial; i > 0; i /= 10)
            {
                sum += i % 10;
            }

            return sum;
        }
    }
}
