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
		
		static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        static void Main()
        {
              Hello("Andy");
              Hello("Maria");
        }
    }
}