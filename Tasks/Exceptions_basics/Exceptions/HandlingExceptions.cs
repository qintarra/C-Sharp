namespace Exceptions
{
    public static class HandlingExceptions
    {
        public static bool CatchArgumentOutOfRangeException1(int i, Func<int, bool> foo)
        {
            // 5-1. Add the try-catch statement to catch an exception of ArgumentOutOfRangeException type. The method should return false if an exception is thrown.
            try
            {
                return foo(i);
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }

    }
}
