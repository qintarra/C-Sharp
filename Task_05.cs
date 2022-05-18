namespace Task_05
{
    public static class Tasks
    {
        public static int Task1(int a)

        /* Given an integer A. If A is positive, then add 1 to it. Otherwise subtract 2 from it.  
         * Example: A = 19  =>  A = 20  
         *          A = -13  =>  A = -15

        {
            if (a > 0)
            {
                return a + 1;
            }
            else
            {
                return a - 2;
            }
        }

        public static int Task3(int a)

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
        }

    }
}

