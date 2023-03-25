namespace ForStatements
{
    public static class GeometricSequences
    {
        public static ulong GetGeometricSequenceTermsProduct(uint a, uint r, uint n)
        {
            // Task 11. Implement the method that returns the product of geometric sequence terms.
            ulong product = 1;

            for (int i = 0; i < n; i++)
            {
                uint rpow = 1;

                for (int j = 0; j < i; j++)
                {
                    rpow *= r;
                }

                product *= a * rpow;
            }

            return product;
        }

        public static ulong SumGeometricSequenceTerms(uint n)
        {
            // Task 12. Implement the method that returns sum of a geometric sequence terms when the first term is 5 and the common ratio is 3.
            const uint firstTerm = 5;
            const uint commonRatio = 3;
            uint sum = 0;

            for (uint i = 0; i < n; i++)
            {
                uint rpow = 1;

                for (uint j = 0; j < i; j++)
                {
                    rpow *= commonRatio;
                }

                sum += firstTerm * rpow;
            }

            return sum;
        }

    }
}
