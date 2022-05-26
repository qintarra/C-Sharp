using System;

namespace Task_11
{
    public static class Tasks
    {
		//One-dimensional array consists of integer elements. Calculate the sum of array elements greater than a.
		
        public static int Task1(int[] array, int a)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > a)
                {
                    result += array[i];
                }
            }

            return result;
        }

        
    }
}