﻿namespace Bools
{
    public static class LogicalOperators
    {
        public static bool LogicalAnd1(bool b1, bool b2)
        {
            // Return the result of logical AND for b1 and b2 parameters.
            return b1 && b2;
        }

        public static bool LogicalAnd2(bool b1, bool b2, bool b3)
        {
            // Return the result of logical AND for b1, b2 and b3 parameters.
            return b1 && b2 && b3;
        }

        public static bool LogicalAnd3(bool b1, bool b2, bool b3, bool b4)
        {
            // Return the result of logical AND for b1, b2, b3 and b4 parameters.
            return b1 && b2 && b3 && b4;
        }

        public static bool LogicalOr1(bool b1, bool b2)
        {
            // Return the result of logical OR for b1 and b2 parameters.
            return b1 || b2;
        }

        public static bool LogicalOr2(bool b1, bool b2, bool b3)
        {
            // Return the result of logical OR for b1, b2 and b3 parameters.
            return b1 || b2 || b3;
        }

        public static bool LogicalOr3(bool b1, bool b2, bool b3, bool b4)
        {
            // Return the result of logical OR for b1, b2, b3 and b4 parameters.
            return b1 || b2 || b3 || b4;
        }

        public static bool LogicalXor1(bool b1, bool b2)
        {
            // Return the result of logical exclusive OR for b1 and b2 parameters.
            return b1 ^ b2;
        }

        public static bool LogicalXor2(bool b1, bool b2, bool b3)
        {
            // Return the result of logical exclusive OR for b1, b2 and b3 parameters.
            return b1 ^ b2 ^ b3;
        }

        public static bool LogicalXor3(bool b1, bool b2, bool b3, bool b4)
        {
            // Return the result of logical AND for b1, b2, b3 and b4 parameters.
            return b1 ^ b2 ^ b3 ^ b4;
        }

        public static bool Negate(bool b)
        {
            // Return the result of logical negation b parameter.
            return !b;
        }
    }
}
