using System;

namespace Notes_06
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Random class and filling the array with random numbers
            Random r = new Random();
            int[] mas = new int[10];

            for (int i = 0; i < 10; i++)
                mas[i] = r.Next(0, 11);

            Console.WriteLine("Random array");
            foreach (int x in mas)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();

            Console.WriteLine("Sum = {0}", mas.Sum());

            Console.WriteLine("Min = {0} Max = {1}", mas.Min(), mas.Max());
			
			
            Array.Reverse(mas);
            Console.WriteLine("Reversed array");
            foreach (int x in mas)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
			
			
            Array.Sort(mas);
            Console.WriteLine("Sorted array");
            foreach (int x in mas)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
			
			
			Console.WriteLine("Enter the number of items");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements into a cloumn");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            foreach (int x in arr)
                Console.Write("{0} ", x);

            Console.WriteLine();
            
        }
    }
}