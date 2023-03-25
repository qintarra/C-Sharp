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

        public static ulong CountGeometricSequenceTerms1(uint a, uint r, uint maxTerm)
        {
            // Task 13. Implement the method that counts terms in a geometric sequence that are less than or equal to the maxTerm.
            uint term = a;
            uint rpow = 1;
            uint j = 0;
            ulong i = 0;
            for (; term <= maxTerm;)
            {
                for (; j < i; j++)
                {
                    rpow *= r;
                }

                term = a * rpow;
                i++;
            }

            return j;
        }

        public static ulong CountGeometricSequenceTerms2(uint a, uint r, uint n, uint minTerm)
        {
            // Task 14. Implement the method that counts terms in a geometric sequence that are greater than or equal to a minTerm.
            uint i = n - 1;
            uint rpow = 1;

            for (uint j = 0; j < i; j++)
            {
                rpow *= r;
            }

            uint term = a * rpow;

            if (term < minTerm && i == n - 1)
            {
                return 0;
            }

            for (; ;)
            {
                if (term <= minTerm || i == 0)
                {
                    break;
                }

                i--;
                rpow /= r;
                term = a * rpow;
            }

            return n - i;
        }
    }
}
