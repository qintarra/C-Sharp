using System;

namespace Notes_02
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = n / 100;
            int b = n / 10 % 10;
            int c = n % 10;
            int max = Math.Max(Math.Max(a, b), c);
            int min = Math.Min(Math.Min(a, b), c);
            int mid = a + b + c - max - min;

            Console.WriteLine(Convert.ToInt32($"{max}{mid}{min}"));
			
            //2.1
            Console.WriteLine("Please, enter a number from 1 to 4");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("You typed 1");
                    break;
                case 2:
                    Console.WriteLine("You typed 2");
                    break;
                case 3:
                    Console.WriteLine("You typed 3");
                    break;
                case 4:
                    Console.WriteLine("You typed 4");
                    break;
                default:
                    Console.WriteLine("You are mistaken");
                    break;
            }
            Console.WriteLine("Continue...");
			
			//2.2
			Console.WriteLine("Where do we go from here? (right, left, straight)");
            string direction = Console.ReadLine();
            switch (direction)
            {
                case "right":
                    Console.WriteLine("Why is the path unclear");
                    break;
                case "left":
                    Console.WriteLine("When we know hope is near?");
                    break;
                case "straight":
                    Console.WriteLine("When does the end appear?");
                    break;
                default:
                    Console.WriteLine("You can tell the end is near");
                    break;
            }

        }


    }
}