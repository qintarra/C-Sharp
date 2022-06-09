using System;

namespace ArrayObject
{
    public static class ArrayTasks
    {
        //In a given array of integers nums swap values of the first and the last array elements, the second and the penultimate etc., if the two exchanged values are even
        //Example: {100, 2, 3, 45, 33, 8, 4, 54} => {54, 4, 3, 45, 33, 8, 2, 100}
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
		
       /*In a given array of integers nums calculate integer result value, that is equal to the distance between the first and the last entry of the maximum value in the array.
        * Example: 
        *			{4, 100!, 3, 4}         result = 0 
        *			{5, 50!, 50!, 4, 5}     result = 1 
        *			{5, 350!, 350, 4, 350!} result = 3 
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


    }
}
