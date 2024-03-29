﻿namespace WhileStatements
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

        public static int SumArithmeticSequenceTerms3(int a, int n)
        {
            // 1-3. Implement the method that returns sum of an arithmetic sequence terms.
            const int commonDifference = 3;
            int sum = 0, i = 0;

            while (i < n)
            {
                sum += a + (i * commonDifference);
                i++;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms4(int a, int d, int n)
        {
            // 1-4. Implement the method that returns sum of an arithmetic sequence terms.
            int sum = 0, i = 0;

            while (i < n)
            {
                sum += a + (i * d);
                i++;
            }

            return sum;
        }
    }
}
