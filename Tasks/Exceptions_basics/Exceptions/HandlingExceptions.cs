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

        public static string CatchArgumentOutOfRangeException2(int i, object o, string s, out string errorMessage)
        {
            errorMessage = null;

            // 5-2. Add the try-catch statement to catch an exception of ArgumentOutOfRangeException type. If an ArgumentOutOfRangeException is thrown, assign errorMessage parameter to the exception's error message and return "K139".
            try
            {
                return DoSomething(i, o, s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                errorMessage = e.Message;
                return "K139";
            }
        }

    }
}
