namespace Exceptions
{
    public static class ThrowingArgument
    {
        public static int CheckParameterAndThrowException1(int i)
        {
            if (i % 2 != 0)
            {
                throw new ArgumentException("i should not be odd.", nameof(i));
            }

            return i;
        }

    }
}
