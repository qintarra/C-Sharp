using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    public static class Tasks
    {
        /*Two-dimensional array consists of integer elements. Find the arithmetic average of elements less than the value of 'a'.
        Example: 
                array: { { 4, 10, 5 },
                         { 3, 2, 35 },
                         { 30, 55, 66 } }
						 
                a = 5	 
                average = 3
        */
        public static double Task1(int[,] array, int a)
        {
            double average = 0;
            double sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)

                for (int j = 0; j < array.GetLength(1); j++)

                    if (array[i, j] < a)
                    {
                        sum += array[i, j];
                        average++;
                    }

            average = sum / average;

            return average;
        }
		
        /*Calculate the amount of negative elements below the main diagonal.
        Example: 
                array: { { 15, 60, 65 },
                         { -5, 14, 53 },
                         { -1, -10 ,59 } }

                amount = 3
        */
        public static int Task2(int[,] array)
        {
            int amount = 0;

            for (int i = 1; i < array.GetLength(0); i++)

                for (int j = 0; j < i; j++)

                    if (array[i, j] < 0)

                    {
                        amount++;
                    }

            return amount;
        }
		
        /*Write the product of the elements of each line, greater than the arithmetic mean of the elements of the line into the new array 'minarray'.
        Example: 
                array: { { 15, 20, 5 },
                         { 15, 3, 9 },
                         { 12, 35 ,6 } }

                minarray = { 300, 15, 35 }
        */
		public static int[] Task3(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int[] minarray = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;

                for (int j = 0; j < columns; j++)
                {
                    sum += array[i, j];
                    minarray[i] = sum / columns;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                int prod = 1;

                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] > minarray[i])
                    {
                        prod *= array[i, j];
                    }
                }
                minarray[i] = prod;
            }
            return minarray;
        }
		
        /*Write the minimum values of each line into the new array 'minarray'.
        Example:
                array: { { 4, 5, -6 },
                         { 13, -15, 14 },
                         { 8, 0 ,2 } }

                minarray: { -6, -15, 0 }
        */
        public static int[] Task4(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int[] minarray = new int[rows];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        minarray[i] = min;
                    }
                }
            }

            return minarray;
        }
    }
}