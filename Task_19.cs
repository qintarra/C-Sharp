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
		
       /* Create function MultArithmeticElements, which determines the multiplication of a given number 
        * of first n elements of an arithmetic progression of real numbers with a given initial element of progression a(1) and progression step t. 
        * a(n) is calculated by the formula a(n+1) = a(n) + t.
        * Example: For a(1) = 5, t = 3, n = 4  multiplication equals to 5*8*11*14 = 6160 
        */
		
        public static double MultArithmeticElements(double a, double t, int n)
        {
            double result = 1.0;

            for (int i = 0; i < n; i++)
            {
                result *= a;
                a += t;
            }
            return result;
        }
        
        
    }
}
