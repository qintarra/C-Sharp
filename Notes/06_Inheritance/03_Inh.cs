using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_7_1
{
    class Person
    {
        public string firstname;
        public string lastname;
        
        public void AboutMe()
        {
            Console.WriteLine($"I'm {firstname} {lastname}.");
        }
    }
    class Student : Person
    {
        public string university;

        //Method overload New signature
        public void AboutMe(string university)
        {
            Console.WriteLine($"I'm {firstname} {lastname}, student of {university}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.firstname = "Bill";
            s.lastname = "Gates";
            s.university = "Harvard";
            s.AboutMe();
            s.AboutMe(s.university);
        }
    }
}