﻿namespace Exceptions
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

        public static bool CheckParametersAndThrowException3(uint i, double d)
        {
            
            if (i >= 5)
            {
                throw new ArgumentOutOfRangeException(nameof(i), "i should be in [0, 5) interval.");
            }

            if (d < -1.0 || d > 1.0)
            {
                throw new ArgumentOutOfRangeException(nameof(d), "d should be in [-1.0, 1.0] interval.");
            }

            return true;
        }


    }
}
