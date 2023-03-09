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

    }
}
