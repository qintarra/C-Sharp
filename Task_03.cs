namespace Task_03
{
    public static class Tasks
    {
        public static void Task1(int n)
		//A two-digit number n is given. Find its left digit (the tens digit).
        {	
            int leftDigit = (int)(n/Math.Pow(10,(int)Math.Floor(Math.Log10(n))));

            Console.WriteLine($"Left digit is {leftDigit}");
        }

    }
}
