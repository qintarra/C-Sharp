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

    }
}
