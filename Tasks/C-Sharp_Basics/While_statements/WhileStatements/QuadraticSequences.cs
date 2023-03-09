namespace WhileStatements
{
    public static class QuadraticSequences
    {
        public static long SumQuadraticSequenceTerms1(long a, long b, long c, long maxTerm)
        {
            // 2-1. Implement the method that returns sum of an quadratic sequence terms.
            long sum = 0, n = 1;

            while (n <= maxTerm)
            {
                long term = (a * n * n) + (b * n) + c;
                if (term <= maxTerm)
                {
                    sum += term;
                }

                n++;
            }

            return sum;
        }

        public static long SumQuadraticSequenceTerms2(long a, long b, long c, long startN, long count)
        {
            // 2-2. Implement the method that returns sum of count quadratic sequence terms.
            long sum = 0;
            long n = startN;

            while (n < startN + count)
            {
                long term = (a * n * n) + (b * n) + c;
                sum += term;
                n++;
            }

            return sum;
        }
    }
}
