using System;

namespace Task_12
{
    public static class Tasks
    {
        //A one-dimensional array consists of integer elements. Calculate the sum and number of nonzero elements of the array.
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
		
        //Calculate the difference between the maximum and the minimum values ​​of the array elements.
        //Example: array = { 0, -6, 2, 120, 4 }  =>  result = 126
        //         array = { 4, 1, 2, 22 }       =>  result = 21
        public static int Task3(int[] array)
        {
            int result = 0;
            int min = array[0];
            int max = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    
                }
                if (max < array[i])
                {
                    max = array[i];
                    
                }
            }

            result = max - min;

            return result;
        }
		
        //Find the minimum value among the elements of the array greater than the value of a.
        //Example: array = { 25, -6, 0, 11, 10 }, a = 10    =>  result = 11
        //         array = { 0, 8, 5, -2 },       a = 4     =>  result = 5
        public static int Task4(int[] array, int a)
        {
            int result = 0;
            int min = 0;
            for (; min < array.Length; min++)
            {
                if (array[min] > a)
                    break;
            }
            for (int i = min + 1; i < array.Length; ++i)
            {
                if (array[i] > a && array[i] < array[min])
                min = i;
            }
            result = array[min];

            return result;
        }
		
        //Add to the value of the elements the values ​​of their indices if the value and index are both even or both odd.
        //Example: array = { -25, -6, 2, 12 }    =>  array = { -25, -6, 4, 12 }
        //         array = { 8, 3, -12, -2 }     =>  array = { 8, 4, -10, -2 }
        public static int[] Task5(int[] array)
        {
            for (int i = 0; i < array.Length; i++)

                if ((array[i] + i) % 2 == 0)
                {
                    array[i] += i;
                }
            return array;
        }
		
        //Double the values ​​of the array elements greater than a, and write zero to all others.
        //Example: array = { 25, -6, 0, 11, 10 }, a = 10    =>  array = { 50, -6, 0, 22, 10 }
        //         array = { 0, 8, 5, -2 },       a = 4     =>  array = { 0, 16, 10, -2 }
        public static int[] Task6(int[] array, int a)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > a)
                {
                    array[i] *= 2;
                }
                if (array[i] <= a)
                {
                    array[i] = 0;
                }

            }
                return array;
        }
    }
}