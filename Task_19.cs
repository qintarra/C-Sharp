using System;

namespace Task_19
{
    public enum SortOrder { Ascending, Descending }
    public static class Function
    {
       /* Create function IsSorted, determining whether a given array of integer values of arbitrary length 
        * is sorted in a given order (the order is set up by enum value SortOrder). 
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
        
        
    }
}
