using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Notes_16_1
{
    class Person
    {
        public string firstname;
        public string lastname;
        public int age;
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
            Console.WriteLine($"I'm {p.firstname} {p.lastname}. I'm {p.age} years old.");

            Student s = new Student();
            s.firstname = "Bill";
            s.lastname = "Gates";
            s.age = 22;
            s.university = "Harvard";
            Console.WriteLine($"I'm {s.firstname} {s.lastname}. I'm {s.age} years old. I study at {s.university}.");

            if (s is Person)
            {
                Console.WriteLine($"Yes, {s.firstname} is a person");
            }
            else
            {
                Console.WriteLine($"No, {s.firstname} isn't a person");
            }
            if (p is Student)
            {
                Console.WriteLine($"Yes, {p.firstname} is a student");
            }
            else
            {
                Console.WriteLine($"No, {p.firstname} isn't a student");
            }
        }
    }
}

using System;
using System.Collections.Generic;
namespace Notes_16_2
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