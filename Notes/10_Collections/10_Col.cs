using System;
using System.Collections.Generic;
namespace Collections_10
{
    class Car
    {
        public string Name { get; }
        public int Price { get; }
        public Car(string name, int price)
        {
            Name = name;
            Price = price;
        }

        // comparison by price
        public class CompareByPrice : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                if (x.Price > y.Price) return 1;
                if (x.Price < y.Price) return -1;
                return 0;
            }
        }
        // comparison by name
        public class CompareByName : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                return String.Compare(x.Name, y.Name);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<Car, string> sl = new SortedList<Car, string>(new
           Car.CompareByName());
            sl.Add(new Car("Ford", 20000), "USA");
            sl.Add(new Car("Mersedes", 25000), "Germany");
            sl.Add(new Car("Mazda", 15000), "Japan");
            sl.Add(new Car("KIA", 13500), "Korea");
            foreach (var x in sl)
            {
                Console.WriteLine("{0} made in {1}", x.Key.Name, x.Value);
            }
        }
    }
}