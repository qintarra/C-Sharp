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

        public static int SumArithmeticSequenceTerms2(int n)
        {
            // Task 2. Implement the method that returns sum of an arithmetic sequence terms.
            int firstTerm = 47;
            int commonDifference = 13;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += firstTerm + (i * commonDifference);
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms3(int a, int n)
        {
            // Task 3. Implement the method that returns sum of an arithmetic sequence terms.
            int commonDifference = 5;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += a + (i * commonDifference);
            }

            return sum;
        }
    }
}
