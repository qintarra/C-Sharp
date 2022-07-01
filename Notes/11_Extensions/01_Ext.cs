using System;
namespace ExtensionMethods_1
{
    class Car
    {
        public int Speed { get; set; } = 50;
        public int SpeedUp()
        {
            Speed += 20;
            return Speed;
        }
    }
    static class CarExtensions
    {
        public static int SlowDown(this Car c)
        {
            c.Speed -= 10;
            return c.Speed;
        }
        public static int Stop(this Car c)
        {
            c.Speed = 0;
            return c.Speed;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(); //Let's go ride!
            Console.WriteLine("Starting speed: {0}", c.Speed);
            Console.WriteLine("Speed up, speed, speed: {0}", c.SpeedUp());
            Console.WriteLine("Speed up, speed, speed: {0}", c.SpeedUp());
            Console.WriteLine("Speed up, speed, speed: {0}", c.SpeedUp());

            Console.WriteLine("Slow down, speed: {0}", c.SlowDown());

            //But it's also possible like this:
            Console.WriteLine("Stop, speed: {0}", CarExtensions.Stop(c));
        }
    }
}