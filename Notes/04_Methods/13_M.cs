using System;
namespace Method_11
{
    enum StaffPosition
    {
        Junior,
        Middle,
        Senior,
        Lead
    }
    internal class Program
    {
        static void Welcome(string name, StaffPosition position)
        {
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine($"Welcome to the position {position} at Amazon!");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Welcome("Jeronimo", StaffPosition.Junior);
            Welcome("Aribeth", StaffPosition.Lead);
        }
    }
}