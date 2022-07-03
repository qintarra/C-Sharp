using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7_5
{
    class Person
    {
        protected string firstname;
        protected string lastname;
        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public void AboutMe()
        {
            Console.WriteLine($"My name is {firstname} {lastname}.");
        }
    }
    class Student : Person
    {
        private string university;
        public Student(string firstname, string lastname, string university):base(firstname, lastname)
        {
            this.university = university;
        }
        public new void AboutMe()
        {
            Console.WriteLine($"I'm {firstname} {lastname}, student of {university}.");
        }
    }
    class Driver : Person
    {
        public string auto;
        public Driver(string firstname, string lastname, string auto) : base(firstname, lastname)
        {
            this.auto = auto;
        }
        public new void AboutMe()
        {
            Console.WriteLine($"I'm {firstname} {lastname}, driver of {auto}.");
        }
    }
    class Programmer : Person
    {
        public string language;
        public Programmer(string firstname, string lastname, string language) : base(firstname, lastname)
        {
            this.language = language;
        }
        public new void AboutMe()
        {
            Console.WriteLine($"I'm {firstname} {lastname}, programming in {language}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student p1 = new Student("Sergey", "Brin", "Stanford");
            Driver p2 = new Driver("Elon", "Musk", "Tesla");
            Programmer p3 = new Programmer("Bill", "Gates", "C#");

            p1.AboutMe();
            p2.AboutMe();
            p3.AboutMe();

            Person[] persons = new Person[3];
            persons[0] = new Student("Sergey", "Brin", "Stanford");
            persons[1] = new Driver("Elon", "Musk", "Tesla");
            persons[2] = new Programmer("Bill", "Gates", "C#");

            foreach (Person p in persons)
            {
                p.AboutMe();
            }
        }
    }
}