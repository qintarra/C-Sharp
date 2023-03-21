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
    }
}
