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
				
        //Calculate the sum of even array elements with even indices.
        //Example: array = { -24, -6, 8, 120 }  =>  result = -16
        public static int Task3(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] % 2 == 0)
                {
                    result += array[i];
                }
            }
            return result;
        }
		
        //Calculate the number of negative elements of the array.
        //Example: array = { 25, -6, 59, -37 }    =>  result = 2
        public static int Task4(int[] array)
        {
            int result = 0;          
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    result++;
                }
            }
            return result;
        }
		
        //Calculate the product of positive elements of the array greater than the value of a.
        //Example: array = { 8, 1, -12, -2 },  a = -5   =>  result = 8
        //         array = { -25, -6, 2, 12 }, a = 1    =>  result = 24
        public static int Task5(int[] array, int a)
        {
            int result = 1;

            for (int i = 0; i < array.Length; i++ )
            {
                if (array[i] > 0 && array[i] > a)
                {
                    result *= array[i];
                }
            }

            return result;
        }
		
        //Calculate the number of array elements whose values ​​are equal to their index.
        //Example: array = { 0, -6, 2, 120, 4 }  =>  result = 3
        //         array = { 4, 1, 2, 22 }       =>  result = 2
        public static int Task6(int[] array)
        {
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == i)
                {
                    result++;
                }
            }

            return result;
        } 
    }
}