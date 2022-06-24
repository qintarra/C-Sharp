using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Association_2
{
    /* Association is a semantically weak relationship (a semantic dependency)
     * between otherwise unrelated objects. 
     * An association is a “using” relationship between two or more objects
     * in which the objects have their own life and there is no owner.
     */
    class Furniture
    {
        public string Name { get; }
        public string Material { get; }
        public Furniture(string name, string material)
        {
            Name = name;
            Material = material;
        }
    }
    class Room
    {
        private double length;
        private double width;
        private Furniture[] furnitures;
        public Room(double length, double width)
        {
            this.length = length;
            this.width = width;
            furnitures = new Furniture[100];
        }
        public double GetAreaRoom()
        {
            return length * width;
        }
        public void AddFurniture(Furniture furniture)
        {
            for (int i = 0; i < 100; i++)
            {
                if (furnitures[i] == null)
                {
                    furnitures[i] = furniture;
                    break;
                }
            }
        }
        public void TakeOutFurniture(Furniture furniture)
        {
            for (int i = 0; i < 100; i++)
            {
                if (furnitures[i] == furniture)
                {
                    furnitures[i] = null;
                }
            }
        }
        public void ListFurniture()
        {
            for (int i = 0; i < 100; i++)
            {
                if (furnitures[i] != null)
                {
                    Console.WriteLine($"{i + 1}.{furnitures[i].Name}");
                }
                else
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Room hall = new Room(4, 5);
            Console.WriteLine($"Area = {hall.GetAreaRoom()}");

            Furniture sofa = new Furniture("Sofa", "Leather");
            Furniture table = new Furniture("Table", "Wood");
            hall.AddFurniture(sofa);
            hall.AddFurniture(table);
            Console.WriteLine("List of furniture in the room");
            hall.ListFurniture();
            hall.TakeOutFurniture(table);
            Console.WriteLine("List of furniture in the room");
            hall.ListFurniture();
        }
    }
}