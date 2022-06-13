using System;

namespace Task_19
{
    public enum SortOrder { Ascending, Descending }
    public static class Function
    {
       /* Create function 'IsSorted', determining whether a given 'array' of integer values of arbitrary length 
        * is sorted in a given 'order' (the order is set up by enum value 'SortOrder'). 
        * Array and sort order are passed by parameters. The function does not change the array.
        */
        public static Boolean IsSorted (int [] array, SortOrder order)
        {
            switch (order)
            {
                case SortOrder.Ascending:
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[i - 1] > array[i])
                            return false;
                    }
                    break;
                case SortOrder.Descending:
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[i - 1] < array[i])
                            return false;
                    }
                    break;
            }
            return true;
        }
		
       /* Create function 'Transform', replacing the value of each element of an integer 'array' with the sum of this element value and its index, 
        * only if the given 'array' is sorted in the given 'order' (the order is set up by enum value SortOrder). 
        * Array and sort order are passed by parameters. To check, if the array is sorted, the function 'IsSorted' from the previous is called.
        * Example: For {5, 17, 24, 88, 33, 2} and “ascending” sort order values in the array do not change.
        *		   For {15, 10, 3} and “ascending” sort order values in the array do not change.
        *		   For {15, 10, 3} and “descending” sort order the values in the array change to {15, 11, 5}.
        */
		
        public static void Transform (int[] array, SortOrder order)
        {
            if (IsSorted(array, order))
                for (int i = 1; i < array.Length; i++)
                    array[i] += i;
        }
        
        
    }
}
