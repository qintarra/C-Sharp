using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace StudentsGroup
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Mark { get; set; }
        public Student(string name, int mark)
        {
            Name = name;
            Mark = mark;
        }
        public int CompareTo(Student other)
        {
            return other.Mark.CompareTo(Mark);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Student[] list = new Student[5];
            list[0] = new Student("Owen", 80);
            list[1] = new Student("Neville", 79);
            list[2] = new Student("Beckham", 85);
            list[3] = new Student("Gerrard", 75);
            list[4] = new Student("Rooney", 94);
            Console.WriteLine("Source List");
            foreach (Student x in list)
            {
                Console.WriteLine("{0,-10} {1}", x.Name, x.Mark);
            }
            Console.WriteLine("Sorted list");
			
            Array.Sort(list);
            foreach (Student x in list)
            {
                Console.WriteLine("{0,-10} {1}", x.Name, x.Mark);
            }
        }
    }
    // SONAR Code smell S1210
    // "Equals" and the comparsion operators should be overriden when iplementing "IComparable"
}