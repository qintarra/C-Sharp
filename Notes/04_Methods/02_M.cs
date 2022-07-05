using System;
namespace Enum_2
{
	//Enumeration type (enum type) is a value type defined by a set of named constants of the underlying integral type of constants
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