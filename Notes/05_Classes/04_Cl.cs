using System;
namespace OOP_3
{
    class Person
    {
        string firstname;
        string lastname;
        int age;

        //Constructor with threee parameters
        public Person (string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        //Constructor to create 27-years old
        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = 27;
        }

        //Parameterless constructor
        public Person()
        {
            firstname = "Isaak";
            lastname = "Azimov";
            age = 70;
        }

        //Method for obtaining all information about a person
        public void AboutMe()
        {
            Console.WriteLine($"My name is {firstname} {lastname} and I'm {age} years old");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Douglas", "Adams", 42);
            p1.AboutMe();

            Person p2 = new Person("James", "Hendrix");
            p2.AboutMe();

            Person p3 = new Person();
            p3.AboutMe();

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Person p4 = new Person(name, lastname, age);
            p4.AboutMe();
        }
    }
}
