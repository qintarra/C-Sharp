using System;

namespace Task_12
{
    public static class Tasks
    {
        //One-dimensional array consists of integer elements. Calculate the sum and number of nonzero elements of the array.
        //Example: array = { 25, -6, 0, 1 }    =>  result = (20, 3)
        //         array = { 0, 0, -12, -20 }  =>  result = (-32, 2)
        public static (int, int) Task1(int[] array)
        {
            int sum = 0, number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    number++;
                    sum += array[i];
                }
            }

            return (sum, number);
        }
		
        //Calculate the arithmetic mean of the array’s elements greater than the value of a.
        //Example: array = { -25, -6, 2, 12 }, a = 1    =>  result = 7
        //         array = { 8, 3, -12, -2 },  a = -5   =>  result = 3

		public static double Task2(int[] array, int a)
        {
            double result = 0.0;
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > a)
                {
					sum += array[i];
                    result++;
                }
            }

            result = sum / result;
			
            return result;
        }


		
	}
}