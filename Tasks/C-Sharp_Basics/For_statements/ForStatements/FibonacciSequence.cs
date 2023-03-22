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

    }
}
