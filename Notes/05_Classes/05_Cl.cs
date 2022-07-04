using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OOP_3_5
{
    class Person
    {
        string firstName;
        string lastName;

        public Person(string firstName = "Unknown", string lastName = "Unknown")
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void Info()
        {
            Console.WriteLine($"Firstname: {firstName}\t Lastname: {lastName}");
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            Person p1 = new Person("Irene", "Adler");
            p1.Info();

            Person p2 = new Person("Anna");
            p2.Info();

            Person p3 = new Person(lastName: "Weber");
            p3.Info();

            Person p4 = new Person();
            p4.Info();
        }
    }
}