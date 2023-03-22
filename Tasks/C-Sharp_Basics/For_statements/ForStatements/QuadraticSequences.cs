namespace ForStatements
{
    public static class QuadraticSequences
    {
        public static uint CountQuadraticSequenceTerms(long a, long b, long c, long maxTerm)
        {
            // Task 6. Implement the method that returns the number of the quadratic sequence terms that are less than or equals to the maxTerm.
            uint count = 1;

            for (long i = 1; i < maxTerm; i++)
            {
                long term = (a * i * i) + (b * i) + c;

                if (term < maxTerm)
                {
                    count++;
                }
                else if (i > 0)
                {
                    return (uint)i;
                }
                else
                {
                    return 0;
                }
            }

            return count;
        }

        public static ulong GetQuadraticSequenceTermsProduct1(uint count)
        {
            // Task 7. Implement the method that returns the product of the first count quadratic sequence terms.
            ulong product = 1;

            for (uint n = 1; n <= count; n++)
            {
                ulong term = (7 * n * n) + (4 * n) + 2;
                product *= term;
            }

            return product;
        }

    }
}
