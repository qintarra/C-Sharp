using System;
using System.Collections.Generic;
using System.Collections;
namespace Collections_4
{
    class Student
    {
        string fname;
        string lname;
        public Student(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }
        public override string ToString()
        {
            return string.Format($"{fname} {lname}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList group1 = new ArrayList();
            group1.Add(new Student("Ivan", "Khakhaliev"));
            group1.Add(new Student("Oleksandra", "Chuprina"));
            group1.Add(new Student("Oleksandr", "Holovaty"));

            // group1.Add("Bill Gates");
            Console.WriteLine("List of students of the first group:");
            foreach (object s in group1)
            {
                Console.WriteLine(s);
            }
            List<Student> group2 = new List<Student>();
            group2.Add(new Student("Yelizaveta", "Filatova"));
            group2.Add(new Student("Vladyslav", "Shevchuk"));
            group2.Add(new Student("Diana", "Hedz"));

            Console.WriteLine("List of students of the second group:");
            foreach (Student s in group2)
            {
                Console.WriteLine(s);
            }
        }
    }
}