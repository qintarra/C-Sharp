using System;
using System.Collections.Generic;

namespace OOP_6_8
{
    class Person
    {
        public string firstname;
        public string lastname;
        public int age;

        public void AboutMe()
        {
            Console.WriteLine($"I'm {firstname} {lastname}. I'm {age} years old.");
        }
    }
    class Student : Person
    {
        public string university;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.firstname = "Mark";
            p.lastname = "Zukerberg";
            p.age = 17;
            p.AboutMe();
            
            Student s = new Student();
            s.firstname = "Bill";
            s.lastname = "Gates";
            s.age = 22;
            s.university = "Harvard";
            s.AboutMe();
        }
    }
}