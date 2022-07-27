using System;

namespace ArrayObject
{
    public static class ArrayTasks
    {
        /* In a given array of integers 'nums' swap values of the first and the last array elements, the second and the penultimate, etc., 
        if the two exchanged values are even
        Example: 
                 { 10 , 5, 3, 4}	           =>  {4, 5, 3, 10} 
                 {100, 2, 3, 4, 5}             => {100, 4, 3, 2, 5} 
                 {100, 2, 3, 45, 33, 8, 4, 54} => {54, 4, 3, 45, 33, 8, 2, 100} 
        */
        public static void ChangeElementsInArray(int[] nums)
        {
            int x;
            for (int i = 0; i < nums.Length / 2; i++)
            {
                if (nums[i] % 2 == 0 && nums[nums.Length -1 -i] % 2 == 0)
                {
                    x = nums[i];
                    nums[i] = nums[nums.Length - 1 - i];
                    nums[nums.Length - 1 - i] = x;
                }
            }
        }
		
       /* In a given array of integers 'nums' calculate the integer result value, 
        which is equal to the distance between the first and the last entry of the maximum value in the array.
        Example: 
                 {4, 100!, 3, 4}         result = 0 
                 {5, 50!, 50!, 4, 5}     result = 1 
                 {5, 350!, 350, 4, 350!} result = 3 
        */
        public static int DistanceBetweenFirstAndLastOccurrenceOfMaxValue(int[] nums)
        {
            int maxFirst = 0;
            int maxLast = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[maxFirst] < nums[i])
                {
                    maxFirst = i;
                }
                if (nums[maxLast] <= nums[i])
                {
                    maxLast = i;
                }
            }
            return maxLast - maxFirst;
        }
		
       /* In a predetermined two-dimensional integer array (square matrix) matrix insert 0 into elements to the left side of the main diagonal, 
        and 1 into elements to the right side of the diagonal.
        Example: 
                 {{2, 4, 3, 3},          {{2, 1, 1, 1},
                 {5, 7, 8, 5},    =>     {0, 7, 1, 1},          
                 {2, 4, 3, 3},           {0, 0, 3, 1},
                 {5, 7, 8, 5}}           {0, 0, 0, 5}}
        */		
        public static void ChangeMatrixDiagonally(Array matrix)
        {
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    matrix.SetValue(0, i, j);
                    matrix.SetValue(1, j, i);
                }
            }
        }
    }
}
