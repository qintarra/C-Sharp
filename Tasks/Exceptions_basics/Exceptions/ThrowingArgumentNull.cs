namespace Exceptions
{
    public static class ThrowingArgumentNull
    {
        public static bool CheckParameterAndThrowException1(object o)
        {
            // 2-1. Add the code to throw the ArgumentNullException if the o argument is null.
            if (o is null)
            {
                throw new ArgumentNullException(nameof(o));
            }

            return true;
        }

        public static bool CheckParametersAndThrowException2(object o1, object o2)
        {
            // 2-2. Add the code to throw the ArgumentNullException if the o1 or o2 argument is null.
            if (o1 is null)
            {
                throw new ArgumentNullException(nameof(o1));
            }

            if (o2 is null)
            {
                throw new ArgumentNullException(nameof(o2));
            }

            return true;
        }

    }
}
