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
                sum += (n % 2 == 0) ? n : 0;
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
		
	public static int Task3(int n)
		
	// Get the sum of the digits of the number n (>0)
	// Example: n = 25041   sum = 12
		
        {
            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }
		
	public static int Task4(int n)
	
	// Get the sum of the even-digits of the number n (>0).
	// Example: n = 215480   sum = 14
	
        {
            int sum = 0;

            while (n > 0)
            {
                
                if (n % 2 == 0)
                {
                    sum += n % 10;
                }
                n /= 10;
            }

            return sum;
        }
    }
}
