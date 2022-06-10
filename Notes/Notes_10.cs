using System;

namespace Notes_10.cs
{
    enum StaffPosition
    {
        Junior,
        Middle,
        Senior,
        Lead
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Career path");
            StaffPosition sp;
            sp = StaffPosition.Junior;
            Console.WriteLine($"Current position: {sp}");

            sp++;
            Console.WriteLine($"Current position: {sp}");

            Console.WriteLine("Salary growth");
            int salary = 400;
            for (StaffPosition p = StaffPosition.Junior; p <= StaffPosition.Lead; p++)
            {
                Console.WriteLine($"Position: {p}, Salary: {salary} $");
                salary += 550;
            }
        }
		
        //10.2
		
        static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        static void Main()
        {
              Hello("Andy");
              Hello("Maria");
        }
		
        //10.3
		
        static void Sum1(int x, int y)
        {
            Console.WriteLine(x+y);
        }

        static int Sum2(int x, int y)
        {
            return x + y;
        }

        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Sum1(a, b);

            //int c = Sum2(a, b);
            Console.WriteLine(Sum2(a,b));
        }
		
        //10.4
		
        //Passing parameters by reference and ref modifier
    
        //Method definition
        static void Sum(ref int x, int y)
        {
            x += y;
            Console.WriteLine($"The value in the method {x}");
        }

        static void Main(string [] args)
        {
            //The argument passed to the ref parameter
            //Must be initialized first
            int x = 10;
            int y = 15;
            Sum(ref x, y); //method call
            Console.WriteLine($"The value after method {x}");
        }
		
        //10.5
		
        //Out modifier
        //To make a parameter output, 'out' modifier is placed in front of it
    
        static void Sum(int x, int y, out int a)
        {
            a = x + y;
        }

        static void Main(string [] args)
        {
            int c = 11, d = 16;
            int z;
            Sum(c, d, out z);
            Console.WriteLine(z);
        }
		
        //10.6
		
        //The advantage of using parameters:
        //you can return several values from the method, not only one
    
        static void GetData(int x, int y, out int area, out int perim)
        {
            area = x * y;
            perim = 2 * (x + y);
        }

        static void Main(string [] args)
        {
            int a = 12, b = 17;
            GetData(a, b, out int area, out int perimeter);
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }
    }
}