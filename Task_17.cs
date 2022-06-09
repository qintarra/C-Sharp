using System;

namespace ArrayObject
{
    public static class ArrayTasks
    {
        //In a given array of integers nums swap values of the first and the last array elements, the second and the penultimate etc., 
        //if the two exchanged values are even
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

    }
}
