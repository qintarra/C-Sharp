namespace Task_06
{
    public static class Tasks
    {
        public static int Task1(int a,  int b, int c)

        /* Given three unequal numbers A, B, C. Find the sum of the two largest of them
         * Example: A = 11;  B = 34 ; C = 7 =>  Result = 45
         *          A = 17;  B = -12 ; C = -6 =>  Result = 11
         *          A = 5;  B = 0 ; C = 13 =>  Result = 18
         */     

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

        public static (int a, int b, int c) Task3(int a, int b, int c)

        /* Given three real type values A, B, C. If their values are in ascending order (A < B< C), then double them; 
         * otherwise, replace the value of each variable with the opposite one.
         * Example: A = 8;  B = 17 ; C = 45 =>  A = 16;  B = 34 ; C = 90
         *          A = -1;  B = 10 ; C = -5 =>  A = 1;  B = -10 ; C = 5
         *          A = -25;  B = -23 ; C = -16 =>  A = -50;  B = -46 ; C = -32
         */

        {
            if (a < b && b < c)
            {
                return (a * 2, b * 2, c * 2);
            }
            else
            {
                return (-a, -b, -c);
            }
        }

        public static (int a, int b, int c) Task4(int a, int b, int c)

        /* Given three real type values A, B, C. If their values are in ascending order (A < B< C) or descending (A > B> C) one, then double them; 
         * otherwise, replace the value of each variable with the opposite one.
         * Example: A = 10;  B = 20 ; C = 30 =>  A = 20;  B = 40 ; C = 60
         *          A = -2;  B = -12 ; C = -32 =>  A = -4;  B = -24 ; C = -64
         *          A = -25;  B = -12 ; C = -21 =>  A = 25;  B = 12 ; C = 21
         */

        {
            if ((a < b && b < c) || (a > b && b > c))
            {
                return (a * 2, b * 2, c * 2);
            }
            else
                return (-a, -b, -c);
        }
    }
}

