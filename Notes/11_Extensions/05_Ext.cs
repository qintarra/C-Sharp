using System;
namespace ExtensionMethods_4
{
    public enum Position
    {
        Trainee,
        Junior_Tester,
        QA,
        Senior_QA,
        QA_Lead
    }
    public static class Extensions
    {
        public static Position minLevel = Position.Junior_Tester;
        public static bool IsRequiredLevel(this Position position)
        {
            return position >= minLevel;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Position p1 = Position.Trainee;
            Position p2 = Position.Junior_Tester;

            //Extensions.minLevel = Position.QA;

            if (p1.IsRequiredLevel())
                Console.WriteLine($"{p1} suitable for the project");
            else
                Console.WriteLine($"{p1} not suitable for the project");
            if (p2.IsRequiredLevel())
                Console.WriteLine($"{p2} suitable for the project");
            else
                Console.WriteLine($"{p2} not suitable for the project");
        }
    }
}