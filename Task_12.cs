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

		
	}
}