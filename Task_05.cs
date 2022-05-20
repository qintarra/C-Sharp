namespace Task_05
{
    public static class Tasks
    {
        public static int Task1(int a)

        /* Given an integer A. If A is positive, then add 1 to it. Otherwise subtract 2 from it.  
         * Example: A = 19  =>  A = 20  
         *          A = -13  =>  A = -15
         */

        {
            if (a > 0)
            {
                return a + 1;
            }
            else
            {
                return a - 2;
            }
		// Another option: a = a > 0 ? a + 1 : a - 2;
        }
		
        public static int Task2(int a)

        /* Given an integer A. If it is positive, then add 4 to it; 
         * if negative, then subtract 7 from it; if zero, then replace it with 5.
         * Example: A = 42  =>  A = 46
         *          A = -14  =>  A = -21
         *          A = 0  =>  A = 5
         */

        {
            if (a > 0)
            {
                return a + 4;
            }
            else
            {
                if (a < 0)
                {
                    return a - 7;
                }
                else
                {
                    return 5;
                }
            }
		// Another option: a = a > 0 ? a + 4 : a < 0 ? a - 7 : a = 5;
        }
		
        public static (int a, int b) Task3(int a, int b)

        /* Two values of integer type are given: A and B. If their values are not equal, then assign the sum of these values to each variable, 
         * and if they are equal, then assign zero values to the variables.
         * Example: A = 5;  B = 5 =>  A = 0; B = 0
         *          A = -25;  B = 8 =>  A = -17; B = -17
         */

        {
            if (a != b)
            {
                return (a = (a + b), b = a);
            }
            else
            {
                return (a = 0, b = 0);
            }
        }

        public static int Task4(int a, int b, int c)

        /* Given three unequal numbers A, B, C. Find the smallest of them.
         * Example: A = 8;  B = -2 ; C = 3 =>  Min = -2
         *          A = -24;  B = -3 ; C = 0 =>  Min = -24
         */

        {
            var min = Math.Min(a, b);
            if (min < c)
            {
                return min;
            }
            else
            {
                return c;
            }
        }
    }
}

