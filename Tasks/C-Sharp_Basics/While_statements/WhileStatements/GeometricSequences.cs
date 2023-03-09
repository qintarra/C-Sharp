namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            // 3-1. Implement the method that returns sum of a geometric sequence terms.
            uint sum = 0, i = 0;

            while (i < n)
            {
                uint j = 0, rpow = 1;

                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            // 3-2. Implement the method that returns sum of a geometric sequence terms.
            const uint firstTerm = 13;
            const uint commonRatio = 3;
            uint sum = 0, i = 0;

            while (i < n)
            {
                uint j = 0, rpow = 1;

                while (j < i)
                {
                    rpow *= commonRatio;
                    j++;
                }

                sum += firstTerm * rpow;
                i++;
            }

            return sum;
        }

    }
}
