namespace Exceptions
{
    public static class ThrowingArgumentOutOfRange
    {
        public static bool CheckParameterAndThrowException1(int i)
        {
            if (i <= -5 || i >= 5)
            {
                throw new ArgumentOutOfRangeException(nameof(i));
            }

            return true;
        }

        public static bool CheckParameterAndThrowException2(ulong l)
        {
            if (l > 7)
            {
                throw new ArgumentOutOfRangeException(nameof(l));
            }

            return true;
        }

        }
    }
}
