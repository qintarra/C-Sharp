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
			
            //Indexes and ranges - an easy way to get subarrays from arrays
            //Indexation
            Index i1 = 3; //number 3 from the begining
            Index i2 = ^4; //number 4 from the end
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"{a[i1]}, {a[i2]}"); //3, 6
			
            //Get range
            var slice = a[i1..i2]; //3, 4, 5
            foreach (var sl in slice)
            {
                Console.WriteLine(sl);
            }
			
            //Use in arrays or rows
            string input = "It's a test of ranges!";
            string output = input[^7..^1];
            Console.WriteLine(output); //Output: Ranges
			
            //Omit the first or last index of a range
            output = input[^7..]; //Equivalemt of input[^7..^0]
            Console.WriteLine(output); //Output: Ranges!

            output = input[..^1]; //Equivalemt of input[^0..^1]
            Console.WriteLine(output); //Output: It's a test of ranges
        }
    }
}