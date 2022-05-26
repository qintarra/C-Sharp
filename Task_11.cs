using System;

namespace Task_11
{
    public static class Tasks
    {
        //One-dimensional array consists of integer elements. Calculate the sum of array elements greater than a.
        //Example: array = { 25, -6, 59, 120 }, a = 25  =>  result = 179
		
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
		
        //Calculate the sum of negative elements of the array.
        //Example: array = { -25, -6, 59, 120 }  =>  result = -31
		
        public static int Task2(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    result += array[i];
                }
            }

            return result;
        }



        
    }
}