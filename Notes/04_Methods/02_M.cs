using System;
namespace Enum_2
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
    }
}