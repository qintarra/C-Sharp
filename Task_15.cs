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

                for (int j = 0; j < array.GetLength(0); j++)

                    if (array[i, j] < a)
                    {
                        sum += array[i, j];
                        average++;
                    }

            average = sum / average;

            return average;
        }

        
    }
}