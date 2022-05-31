using System;

namespace Notes_07
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Remember about the reference type of arrays
			
            //Create the first array of the integers
            int[] arr1 = new int[3];
            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;
			
			//Displaying the first array
            Console.WriteLine("First array");
            foreach (int x in arr1)
            {
                Console.WriteLine(x);
            }
            
        }
    }
}