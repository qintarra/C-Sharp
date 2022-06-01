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
            
            //Create the second array, copy the first into it
            int[] arr2 = arr1;
            Console.WriteLine("Second array");
            foreach (int x in arr2)
            {
                Console.WriteLine(x);
            }
			
            //Change the value of an element of the second array
            arr2[0] = 100;
			
            //Displaying the second array
            Console.WriteLine("Second array");
            foreach (int x in arr2)
            {
                Console.WriteLine(x);
            }
			
            //Displaying the first array
            Console.WriteLine("First array");
            foreach (int x in arr1)
            {
                Console.WriteLine(x);
            }
			
			
            //Get array elements from the end
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine(numbers[^1]);
            Console.WriteLine(numbers[^2]);
            Console.WriteLine(numbers[^3]);
        }
    }
}