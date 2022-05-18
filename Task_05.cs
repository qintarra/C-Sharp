namespace Task_05
{
    public static class Tasks
    {
        public static int Task1(int a)

        /* Given an integer A. If A is positive, then add 1 to it. Otherwise subtract 2 from it.  
         * Example
         * A = 19  =>  A = 20
         * A = -13  =>  A = -15
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
        }
    }
}

