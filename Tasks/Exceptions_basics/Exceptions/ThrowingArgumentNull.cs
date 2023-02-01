﻿namespace Exceptions
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

        public static int CheckParametersAndThrowException3(int[] integers, long[] longs, float[] floats)
        {
            // 2-3. Add the code to throw the ArgumentNullException if the integers, longs or floats argument is null.
            if (integers is null)
            {
                throw new ArgumentNullException(nameof(integers));
            }

            if (longs is null)
            {
                throw new ArgumentNullException(nameof(longs));
            }

            if (floats is null)
            {
                throw new ArgumentNullException(nameof(floats));
            }

            return integers.Length + longs.Length + floats.Length;
        }

    }
}
