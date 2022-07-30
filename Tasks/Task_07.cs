namespace Task_07
{
    public static class Tasks
    {       		
        // Get the sum of even numbers in the interval from 'n' to 'm' including.
        // Example: n = 4, m = 9   sum = 18 
        public static int Task1(int n, int m)
        {
            int sum = 0;

            while (n <= m)
            {
                sum += (n % 2 == 0) ? n : 0;
                n++;
            }

            return sum;
        }
			
        // Get the sum of odd numbers in the interval from 'n' to 'm' including.
        // Example: n = 4, m = 10   sum = 21
        public static int Task2(int n, int m)
		
        {
            int sum = 0;

            while(n <= m)
            {
                sum += (n % 2 == 1) ? n : 0;
                n++;
            }

            return sum;
        }
		        		
        // Get the sum of the digits of the number 'n' (>0)
        // Example: n = 25041   sum = 12
        public static int Task3(int n)
		
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
		
        public static int Task5(int n)
	
        // Choose the larger of the two values. The first value is the sum of all even-digits of the number n (>0), 
        // the second value is the sum of all odd-digits of the number n (>0).
        // Example: n = 52012  max = 6
	
        {
            int sum1 = 0;
            int sum2 = 0;

            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    sum1 += n % 10;
                }
                else if (n % 2 != 0)
                {
                    sum2 += n % 10;
                }
                n /= 10;
            }
            int max = Math.Max(sum1, sum2);

            return max;
        }
		
        public static int Task6(int n)
	
        // Find the smallest integer that can be obtained by rearranging the digits of number n (>0).
        // Example: n = 31041   result = 1134
	
        {
            int result = int.Parse(new string(n.ToString().OrderBy(n => n).ToArray()));

            return result;
        }
		
        public static int Task7(int n)
	
        //Find the maximum integer, that can be obtained by numbers of an arbitrary three-digit positive integer n permutation (100<=n<=999).
        //Example: n = 165   result =  651 
        {
            int a = n /100;
            int b = n / 10 % 10;
            int c = n % 10;
            int min = Math.Min(Math.Min(a, b), c);
            int max = Math.Max(Math.Max(a, b), c);
            int mid = a + b + c - max - min;
            return Convert.ToInt32($"{max}{mid}{min}");
			
            //int result = int.Parse(new string(n.ToString().OrderByDescending(n => n).ToArray()));
            //return result;
        }
    }
}
