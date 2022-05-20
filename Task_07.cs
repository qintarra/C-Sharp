namespace Task_07
{
    public static class Tasks
    {
        public static int Task1(int n, int m)
		
	// Get the sum of even numbers in the interval from n to m including.
	// Example: n = 4, m = 9   sum = 18 
		
        {
            int sum = 0;

            while (n <= m)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
                n++;
            }

            return sum;
        }
		
		public static int Task2(int n, int m)
		
	// Get the sum of odd numbers in the interval from n to m including.
	// Example: n = 4, m = 10   sum = 21
		
        {
            int sum = 0;

            while(n <= m)
            {
                sum += (n % 2 == 1) ? n : 0;
                n++;
            }

            return sum;
        }

    }
}
