using System;
using System.Collections.Generic;
namespace Collections_5
{
    class Student
    {
        public string Name { get; set; }
        public Student(string name)
        {
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // FIFO (First In First Out)
            Queue<Student> interview = new Queue<Student>();
            interview.Enqueue(new Student("Bohuta Stanislav"));
            interview.Enqueue(new Student("Kovalenko Anastasiia"));
            interview.Enqueue(new Student("Rykun Oleh"));
            interview.Enqueue(new Student("Zaichenko Yuliia"));
            interview.Enqueue(new Student("Riabokon Zakhar"));
            Console.WriteLine($"First student: {interview.Peek().Name}");
            Console.WriteLine($"Total students in the interview queue: { interview.Count}");
            Console.WriteLine("The order of the interview:");
            foreach (Student student in interview)
            {
                Console.WriteLine(student.Name);
            }
            // Console.WriteLine($"{interview[2]} Can I skip the line?");
            Console.WriteLine("Start interview");
            while (interview.Count > 0)
            {
                Console.WriteLine($"{interview.Dequeue().Name} successfully passed the interview");
            }
            Console.WriteLine($"Total students in the interview queue: { interview.Count}");
        }
    }
}