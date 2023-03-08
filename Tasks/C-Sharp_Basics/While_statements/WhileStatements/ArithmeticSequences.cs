namespace WhileStatements
{
    public static class ArithmeticSequences
    {
        public static int SumArithmeticSequenceTerms1(int a, int n)
        {
            // 1-1. Implement the method that returns sum of an arithmetic sequence terms.
            int sum = 0, i = 0;

            while (i < n)
            {
                sum += a + i;
                i++;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms2(int n)
        {
            // 1-2. Implement the method that returns sum of an arithmetic sequence terms.
            const int firstTerm = 17;
            const int commonDifference = 33;
            int sum = 0, i = 0;

            while (i < n)
            {
                sum += firstTerm + (i * commonDifference);
                i++;
            }

            return sum;
        }

    }
}
