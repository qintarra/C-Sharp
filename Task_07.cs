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

    }
}
