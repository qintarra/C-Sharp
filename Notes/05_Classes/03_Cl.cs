using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OOP_2_5
{
    class Person
    {
        string firstname;
        string lastname;
        int age;

        /* Constructor
         * A constructor is a method whose name is the same as the name of its type
         * Its method signature includes only the method name and its parameter list
         * it doesn't include the return type
         */
        public Person()
        {
            firstname = "Stanislaw";
            lastname = "Lem";
            age = 40;
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
            Person p1 = new Person();
            p1.AboutMe();

            Person p2 = new Person();
            p2.AboutMe();

            Person p3 = new Person();
            p3.AboutMe();
        }
    }
}