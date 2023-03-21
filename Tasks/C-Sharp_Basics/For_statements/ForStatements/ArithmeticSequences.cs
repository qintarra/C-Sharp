namespace ForStatements
{
    public static class ArithmeticSequences
    {
        public static int SumArithmeticSequenceTerms1(int a, int n)
        {
            // Task 1. Implement the method that returns sum of an arithmetic sequence terms.
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += a + i;
            }

            return sum;
        }

    }
}
