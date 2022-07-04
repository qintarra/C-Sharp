using System;

namespace OOP_5_5_All_static
{
    class Person
    {
        private string name;
        private int number;
        private static int total;
        static Person()
        {
            total = 1;
        }
        public Person (string name)
        {
            number = total;
            this.name = name;
            total++;
        }
        public static int Total
        {
            get
            {
                return total - 1;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public static void AboutUs()
        {
            Console.WriteLine($"We are the people and there are a {Total} of us");
        }
        public void AboutMe()
        {
            Console.WriteLine($"My name is {name} and I'm object number {number}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person("Tom");
            Person john = new Person("John");
            Person ann = new Person("Ann");

            Console.WriteLine($"My name is {tom.Name}");

            tom.AboutMe();
            john.AboutMe();
            ann.AboutMe();

            Person.AboutUs();
            Console.WriteLine(Person.Total);
        }
    }
}