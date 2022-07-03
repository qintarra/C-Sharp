using System;
using System.Collections.Generic;
using System.Text;
namespace OOP_2
{
    class Person
    {
        private string firstname;
        private string lastname;
        private int age;

        //Method of setting the value of the "firstname" field
        public void SetFirstname (string firstname)
        {
            this.firstname = firstname;
        }

        //Method of getting the value of the "firstname" field
        public string GetFirstName ()
        {
            return firstname;
        }

        public void SetLastname(string surname)
        {
            lastname = surname;
        }

        public string GetLastName ()
        {
            return lastname;
        }

        public void SetAge(int age)
        {
            if (age > 0)
                this.age = age;
            else Console.WriteLine("Wrong age");
        }

        public int GetAge()
        {
            return age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SetFirstname("Stanislaw");
            p1.SetLastname("Lem");
            p1.SetAge(40);

            //We display the name, surname, and age of a person

            Console.WriteLine($"Firstname: {p1.GetFirstName()}\nLastname: {p1.GetLastName()}\nAge: {p1.GetAge()} years");

            //A year has passed...

            //The age of a person has changed
            p1.SetAge(41);
            //Once again, we display the name, surname, and age of a person
            Console.WriteLine($"Firstname: {p1.GetFirstName()}\nLastname: {p1.GetLastName()}\nAge: {p1.GetAge()} years");
        }
    }
}