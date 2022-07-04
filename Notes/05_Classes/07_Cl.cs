using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OOP_4_5
{
    class Person
    {
        public string Name { get; private set; }
        public int Age { get; set; }
        public Person()
        {
            Name = "Helena";
            Age = 20;
        }
    }

    //Auto-property
    class NewPerson
    {
        public string Name { get; } = "Edward";
        public int Age { get; set; } = 22;
    }

    class Program
    {
        static void Main (string [] args)
        {
            Person p1 = new Person();
            Console.WriteLine($"Name: {p1.Name}\t Age: {p1.Age}");
            p1.Age = 21;
            Console.WriteLine($"Name: {p1.Name}\t Age: {p1.Age}");

            NewPerson p2 = new NewPerson();
            Console.WriteLine($"Name: {p2.Name}\t Age: {p2.Age}");
            p2.Age = 25;
            Console.WriteLine($"Name: {p2.Name}\t Age: {p2.Age}");
        }
    }
}