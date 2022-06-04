using System;

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
            
                for (int j = 0; j < array.GetLength(0); j++)

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



    }
}