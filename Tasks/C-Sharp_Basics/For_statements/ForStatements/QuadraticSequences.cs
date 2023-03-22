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

    }
}
