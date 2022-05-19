namespace Task_06
{
    public static class Tasks
    {
        public static int Task1(int a,  int b, int c)
		
		/* Given three unequal numbers A, B, C. Find the sum of the two largest of them
		 * Example: A = 11;  B = 34 ; C = 7 =>  Result = 45
		 *			A = 17;  B = -12 ; C = -6 =>  Result = 11
		 *			A = 5;  B = 0 ; C = 13 =>  Result = 18
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
    } 
}

