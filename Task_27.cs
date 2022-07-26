using System;
using System.Collections.Generic;

namespace GenericsTask
{
    public class ClassicCar
    {
        public string m_Make;
        public string m_Model;
        public int m_Year;
        public int m_Value;

        public ClassicCar(string make, string model, int year, int val)
        {
            m_Make = make;
            m_Model = model;
            m_Year = year;
            m_Value = val;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<ClassicCar> carList = new List<ClassicCar>();
            PopulateData(carList);

            // How many cars are in the collection?
            Console.WriteLine("There are {0} cars in the entire collection.\n", carList.Count);

            // How many Fords are there?
            List<ClassicCar> fordList = carList.FindAll(FindFords);
            Console.WriteLine("There are {0} Fords in the entire collection.\n", fordList.Count);

            // What is the most valuable car?
            ClassicCar mostValCar = null;
            int highValue = 0;
            foreach (ClassicCar c in carList)
            {
                if (c.m_Value > highValue)
                {
                    mostValCar = c;
                    highValue = c.m_Value;
                }
            }
            Console.WriteLine("The most valuable car is a {0} {1} {2} at ${3}\n",
                mostValCar.m_Year, mostValCar.m_Make, mostValCar.m_Model, mostValCar.m_Value);


            // What is the entire collection worth?
            int totalValue = 0;
            foreach (ClassicCar c in carList)
            {
                totalValue += c.m_Value;
            }
            Console.WriteLine("The collection is worth ${0}\n", totalValue);

            // How many unique manufacturers are there?
            Dictionary<string, bool> makes = new Dictionary<string, bool>();

            foreach (ClassicCar c in carList)
            {
                try
                {
                    makes.Add(c.m_Make, true);
                }
                catch (Exception e) { }
            };
            Console.WriteLine("The collection contains {0} unique manufacturers.\n", makes.Keys.Count);


            Console.WriteLine("\nHit Enter key to continue...");
            Console.ReadLine();
        }

        

        
    }
}
