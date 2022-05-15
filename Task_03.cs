namespace Task_03
{
    public static class Tasks
    {
        public static void Task1(int n)
		//A two-digit number n is given. Find the sum and the product of its digits.
		//Example: n = 45  =>  sum = 9,  product = 20
        {
			int sum = (n/10) + (n%10);
            int product = (n/10) * (n%10);

            Console.WriteLine($"Sum = {sum}, Product = {product}");
        }
    }
}
