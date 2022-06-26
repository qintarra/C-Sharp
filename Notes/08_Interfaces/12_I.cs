using System;
namespace OOP_18
{
    class Student : IComparable
    {
        public string Name { get; set; }
        public int Mark { get; set; }
        public Student(string name, int mark)
        {
            Name = name;
            Mark = mark;
        }
        public int CompareTo(object obj)
        {
            if (obj is null) return 1;
            Student otherStudent = obj as Student;
            if (!(otherStudent is null))
            {
                if (Mark > otherStudent.Mark) return 1;
                else
                if (Mark < otherStudent.Mark) return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("Object is not a Student");
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
}