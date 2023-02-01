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

    }
}
