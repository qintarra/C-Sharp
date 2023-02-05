namespace Exceptions
{
    public static class NullCoalescingAssignment
    {
        public static object CheckParameterAndThrowException1(object o)
        {
            // 3-1. Use the null-coalescing assignment operator to initialize the o parameter with the default value.
            o ??= new object();

            return o;
        }

        public static int[] CheckParameterAndThrowException2(int[] integers)
        {
            // 3-2. Use the null-coalescing assignment operator to initialize the integers parameter with the default value.
            integers ??= new int[] { 0 };

            return integers;
        }

        public static string CheckParameterAndThrowException3(string s)
        {
            // 3-3. Use the null-coalescing assignment operator to initialize the s parameter with the default value.
            s ??= "Hello, world!";

            return s;
        }

        public static string CheckParametersAndThrowException4(string s1, string s2)
        {s.
            s1 ??= "Hello";
            s2 ??= "world";

            return $"{s1}, {s2}!";
        }

        public static string CheckParametersAndThrowException5(string s1, int[] integers, string s2)
        {
            s1 ??= "abc";
            integers ??= new int[] { 1, 2, 3 };
            s2 ??= "123";

            return $"{s1}{integers.Length}{s2}";
        }
    }
}
