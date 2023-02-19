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

        public static string CatchArgumentNullException3(object o, Func<object, string> foo)
        {
            // 5-3. Add the try-catch statement here to catch an exception of ArgumentNullException type. The method should return "P456" string if an exception is thrown.
            try
            {
                return foo(o);
            }
            catch (ArgumentNullException)
            {
                return "P456";
            }
        }

        public static string CatchArgumentNullException4(int i, object o, string s, out string errorMessage)
        {
            errorMessage = null;

            // 5-4. Add the try-catch statement to catch an exception of ArgumentNullException type. If an ArgumentNullException is thrown, assign errorMessage parameter to the exception's error message and return "A732".
            try
            {
                return DoSomething(i, o, s);
            }
            catch (ArgumentNullException e)
            {
                errorMessage = e.Message;
                return "A732";
            }
        }

        public static int CatchArgumentException5(int[] integers, Func<int[], int> foo)
        {
            // 5-5. Add the try-catch statement here to catch an exception of ArgumentException type. The method should return "0" value if an exception is thrown.
            try
            {
                return foo(integers);
            }
            catch (ArgumentException)
            {
                return 0;
            }
        }

        public static string CatchArgumentException6(int i, object o, string s, out string errorMessage)
        {
            errorMessage = null;

            // 5-6. Add the try-catch statement to catch an exception of ArgumentException type. If an ArgumentException is thrown, assign errorMessage parameter to the exception's error message and return "D948".
            try
            {
                return DoSomething(i, o, s);
            }
            catch (ArgumentException e)
            {
                errorMessage = e.Message;
                return "D948";
            }
        }

        public static string CatchArgumentException7(int i, object o, string s, out string errorMessage)
        {
            errorMessage = null;

            // 5-7. Add the try-catch statement to catch three exception types - ArgumentException, ArgumentNullException and ArgumentOutOfRangeException. See README.md for details.
            try
            {
                return DoSomething(i, o, s);
            }
            catch (ArgumentOutOfRangeException r)
            {
                errorMessage = r.Message;
                return "Z029";
            }
            catch (ArgumentNullException n)
            {
                errorMessage = n.Message;
                return "W694";
            }
            catch (ArgumentException e)
            {
                errorMessage = e.Message;
                return "J954";
            }
        }

    }
}
