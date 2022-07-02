using System;
using System.Collections.Generic;
using System.Text;

namespace Notes_7_2
{
    class Person
    {
        public string firstname;
        public string lastname;
        
        public void AboutMe()
        {
            Console.WriteLine($"My name is {firstname} {lastname}.");
        }
    }
    class Student : Person
    {
        public string university;

        //Overriding parent class method
        public new void AboutMe()
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

            //Casting to parent class type
            ((Person)s).AboutMe();

            //Another option of casting to parent class type
            (s as Person).AboutMe();
        }
    }
}