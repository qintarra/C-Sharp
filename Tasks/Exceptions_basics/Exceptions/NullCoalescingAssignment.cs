namespace Exceptions
{
    public static class NullCoalescingAssignment
    {
        public static object CheckParameterAndThrowException1(object o)
        {
            o ??= new object();

            return o;
        }

        public static int[] CheckParameterAndThrowException2(int[] integers)
        {
            integers ??= new int[] { 0 };

            return integers;
        }

    }
}
