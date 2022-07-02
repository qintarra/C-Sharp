using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Notes_7_3
{
    class Person
    {
        public string firstname;
        public string lastname;
        
        public virtual void AboutMe()
        {
            Console.WriteLine($"My name is {firstname} {lastname}.");
        }
    }
    class Student : Person
    {
        public string university;

        //Virtual method override
        public override void AboutMe()
        {
            Console.WriteLine($"I'm {firstname} {lastname}, student of {university}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.firstname = "Mark";
            p.lastname = "Zukerberg";
            p.AboutMe();

            Student s = new Student();
            s.firstname = "Bill";
            s.lastname = "Gates";
            s.university = "Harvard";
            s.AboutMe();

            (s as Person).AboutMe();
        }
    }
}