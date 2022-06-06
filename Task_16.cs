using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16
{
    public static class Tasks
    {
        /*Two-dimensional array consists of integer elements. Find the sum of the minimum elements of all columns.
        Example:
                array: { { 21, 12, 7 },
                         { -3, -14, 3 },
                         { 9, -19 ,15 } }

                sum = -19
        */
        public static int Task1(int[,] array)
        {
            int sum = 0;

            int [] min = new int [array.GetLength(0)];

            for (int j = 0; j < array.GetLength(0); j++)
            {
                min[j] = array[0, j];

                for (int i = 0; i < array.GetLength(1); i++)
                {
                    if (min[j] > array[i, j])

                        min[j] = array[i, j];
                }
                sum += min[j];
            }

            return sum;
        }
		
        /*Calculate the product of the elements of the main diagonal.
        Example:
                array: { { 5, 7, 50 },
                         { 10, 30, 305 },
                         { -10, 50 ,60 } }

                product = 9000
        */
        public static int Task2(int[,] array)
        {
            int product = 1;

            for (int i = 0; i < array.GetLength(0); i++)
                
                product *= array[i, i];

            return product;
        }
		
        /*Write the sum of the elements of each column into the new array 'sumarray'.
        Example:
                array: { { 0, 90, 90 },
                         { 7, 3, 3 },
                         { 72, 5 ,56 } }

                sumarray = { 79, 98, 149 }
        */
        public static int[] Task3(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int[] sumarray = new int[columns];

            for (int i = 0; i < rows; i++)
            
                for (int j = 0; j < columns; j++)
                
                    sumarray [j] += array[i, j];
                 
            return sumarray;
        }
		
        /*Find the maximum value among the arithmetic means of the strings.
        Example:
                array: { { 2, 4, 4 },
                       { 1, 0, 3 },
                       { 2, 5 ,3 } }

                maxValue = 3.33
        */
        public static double Task4(int[,] array)
        {
            double maxValue = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                double sum = 0;
                double mean = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                    mean = sum / array.GetLength(0);
                }

                if (mean > maxValue)
                    maxValue = mean;
            }

            return maxValue;
        }
    }
}
	