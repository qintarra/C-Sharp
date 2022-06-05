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


        
    }
}