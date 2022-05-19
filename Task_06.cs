namespace Task_06
{
    public static class Tasks
    {
        public static int Task1(int a,  int b, int c)
        {
            var result = 0;
            if (a > b && b > c)
            {
                result = a + b;
            }
            if (a > b && c > b)
            {
                result = a + c;
            }
            if (b > a && a > c)
            {
                result = b + a;
            }
            if (b > a && c > a)
            {
                result = b + c;
            }
            return result;
        }

        public static (int a, int b, int c) Task2(int a, int b, int c)

            /* Given three real type values A, B, C. Rewrite the values of the variables so that A has the smaller of the values, and C has the larger one.
             * Example: A = 10;  B = -15 ; C = 7 =>  A = -15;  B = -15 ; C = 10
             *          A = -1;  B = 10 ; C = 5 =>  A = -1;  B = 10 ; C = 10
             *          A = -17;  B = -2 ; C = -14 =>  A = -17;  B = -2 ; C = -2
             */

        {
            int min = Math.Min(Math.Min(a, b), c);
            int max = Math.Max(Math.Max(a, b), c);
            a = min;
            c = max;
            return (a, b, c);
        }


    }
}

