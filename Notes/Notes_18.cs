using System;
using System.Drawing;
using System.Text;

namespace OOP_Сomposition
{
    /* Composition is a specialized form of aggregation.
       In composition, if the parent object is destroyed,
       then the child objects also cease to exist.
       Composition is actually a strong type of aggregation
       and is sometimes referred to as a “death” relationship.
    */

    class Room
    {
        private double length;
        private double width;
        public Room(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double GetAreaRoom()
        {
            return length * width;
        }
    }
    class House
    {
        Room hall;
        Room bedroom;
        Color colorRoof;
        public House(double length1, double width1, double length2, double width2, Color color)
        {
            hall = new Room(length1, width1);
            bedroom = new Room(length2, width2);
            colorRoof = color;
        }
        public double GetAreaHouse()
        {
            return hall.GetAreaRoom() + bedroom.GetAreaRoom();
        }
        public string GetColorRoof()
        {
            return colorRoof.Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House(6, 5, 3, 4, Color.Brown);
            House house2 = new House(5, 8, 3, 3, Color.Green);
            if (house1.GetAreaHouse() > house2.GetAreaHouse())
            {
                Console.WriteLine("The first house is bigger than the second");
                Console.WriteLine($"It has a {house1.GetColorRoof()} roof");
            }
            else
            {
                Console.WriteLine("The second house is bigger than the first");
                Console.WriteLine($"It has a {house2.GetColorRoof()} roof");
            }
        }
    }
}
