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

	}
}
	