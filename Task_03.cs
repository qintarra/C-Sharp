namespace Task_03  
{  
    public static class Tasks  
    {  
        public static void Task1(int n)  
		//A two-digit number n is given. Find the sum and the product of its digits.  
		//Example n = 45  =>  sum = 9,  product = 20  
        {  
			int sum = (n/10) + (n%10);  
            int product = (n/10) * (n%10);  
  
            Console.WriteLine($"Sum = {sum}, Product = {product}");  
        }  
		  
		public static void Task2(int n)  
		//A three-digit number n is given. Find the sum and the product of its digits.  
		//Example n = 450  =>  sum = 9,  product = 0  
				//n = 817  =>  sum = 16, product = 56  
        {  
            int sum = (n/100) + ((n/10)%10) + (n%10);  
            int product = (n/100) * ((n/10)%10) * (n%10);  
  
            Console.WriteLine($"Sum = {sum}, Product = {product}");  
        }  
  		
		public static void Task3(int n)  
		//A three-digit number n is given. The first left digit was crossed out and ascribed to the right. Find the obtained number.  
		//Example n = 450  =>  result = 504  
				//n = 807  =>  result = 78  
				//n = 695  =>  result = 956  
        {  
            int result = ((n/10)%10) * 100 + (n%10) * 10 + (n/100);
  
            Console.WriteLine($"Result is {result}");  
        }  
  		
		public static void Task4(int n)  
		//A two-digit number n is given. Find the number that was obtained after reordering the initial numbers.  
		//Example n = 45  result = 54  
				//n = 80  result = 8  
				//n = 69  result = 96  
        {  
            int result = 10 * (n % 10) + (n / 10);  

            Console.WriteLine(result);  
        }  
  		
		public static void Task5(int n)  
		//A three-digit number n is given. Find the number that was obtained by processing the initial digit from the right to the left.  
		//Example n = 450  result = 54  
				//n = 807  result = 708  
				//n = 695  result = 596  
		{  
            int result = 100 * (n % 10) + 10 * (n % 100 / 10) + (n / 100);  
  
            Console.WriteLine(result);  
        }  
  		
		public static void Task5(int n)  
		//A three-digit number n is given. The first right digit was crossed out and ascribed to the left. Find the obtained number.  
		//Example n = 450  result = 45  
				//n = 807  result = 780  
				//n = 695  result = 569  
        {  
            int result = 100 * (n % 10) + 10 * (n / 100) + (n % 100 / 10);  
  
            Console.WriteLine(result);  
        }  
    }  
}  
