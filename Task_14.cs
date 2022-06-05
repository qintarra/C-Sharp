using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    public static class Tasks
    {
        /*Two-dimensional array consists of integer elements. Calculate the sum of positive elements of the array.
        Example: 
                array: { { -12, 3, 5 },
                         { 31, -22, 3 },
                         { -30, -5, 13 } };
                sum = 55;
        */
        public static int Task1(int[,] array)
        {
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            
                for (int j = 0; j < array.GetLength(1); j++)

                    if (array[i, j] > 0)
                    {
                        sum += array[i, j];
                    }

            return sum;
        }
		
        /*Calculate the sum of positive elements of the array that are located above the main diagonal.
        Example:
                array: { { 21, 12, 7 },
                         { -3, -14, -52 },
                         { 9, -14 ,15 } }

                sum = 19;
        */
		
        public static int Task2(int[,] matrix)
        {
            int sum = 0;

            for (int i = 1; i < matrix.GetLength(0); i++)
            
                for (int j = 0; j < i; j++)

                    if (matrix[i, j] > 0)

                    {
                        sum += matrix[j, i];
                    }

            return sum;
        }
		
        /*Rewrite the values of the elements, subtracting from them the value of the row number of the element.
        Example:
                array: { { 4, 5, -6 },
                         { 13, -15, 14 },
                         { 0, 4 ,2 } }


                result:{ { 4, 5, -6 },
                         { 12, -16, 13 },
                         { -2, 2 ,0 } }
        */
        public static void Task3(int[,] matrix)
        {

            for (int i = 1; i < matrix.GetLength(0); i++)

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] -= i;
                }

        }
		
        /*Calculate the product of positive elements greater than the value of 'a'.
        Example:
                array: { { -12, 3, 5 },
                         { 6, -22, 3 },
                         { -30, -5, 13 } };

                product = 78;
        */
		
        public static int Task4(int[,] array, int a)
        {
            int product = 1;

            for (int i = 0; i < array.GetLength(0); i++)

                for (int j = 0; j < array.GetLength(1); j++)

                    if (array[i, j] > a)
                    {
                        product *= array[i, j];
                    }

            return product;
        }
		
        /*Find the sum of the minimum elements of all columns.
        Example:
                array: { { 21, 12, 7 },
                         { -3, -14, 3 },
                         { 9, -19 ,15 } };

                sum = -19;
        */
		
        public static int Task5(int[,] array)
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
		
        /*Write the minimum values of each line into the new array 'minarray'.
        Example:
                array: { { 4, 5, -6 },
                         { 13, -15, 14 },
                         { 8, 0 ,2 } }


                minarray: { -6, -15, 0 };
        */
		
        public static int[] Task3(int[,] array)
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