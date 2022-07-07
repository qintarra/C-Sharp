using System;
namespace enum
{
    public static class Program
    {
        static void Main(string [] args)
        {
            DayOfWeek day = DateTime.Now.DayOfWeek;
            Console.WriteLine($"Today is {day}");
			
            switch (day)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Thursday:
                    Console.WriteLine("Listening lecture today");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Doing homework");
                    break;
                default:
                    Console.WriteLine("Resting and reading");
                    break;
            }
        }
    }
}