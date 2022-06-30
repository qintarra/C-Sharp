using System;
using System.Collections;
namespace Collections_12
{
    public class Student
    {
        public string Name { get; }
        public int Rate { get; set; }
        public Student(string name, int rate)
        {
            Name = name;
            Rate = rate;
        }
        public override string ToString()
        {
            return string.Format("{0} has rate {1}", Name, Rate);
        }
    }

    public class StudentCollection : IEnumerable
    {
        private IList List { get; }
        public StudentCollection()
        {
            List = new ArrayList();
        }
        public int Count
        {
            get { return List.Count; }
        }
        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < Count; index++)
            {
                yield return List[index];
            }
        }
        public int Add(string name, int rate)
        {
            return List.Add(new Student(name, rate));
        }
        public int Add(Student student)
        {
            return List.Add(student);
        }
        public void RemoveAt(int index)
        {
            List.RemoveAt(index);
        }
        public void Remove(Student student)
        {
            List.Remove(student);
        }
        public Student this[int index]
        {
            get
            {
                return (Student)List[index];
            }
            set
            {
                List[index] = value;
            }
        }
        public Student BestStudent()
        {
            int numberBest = 0;
            for (int i = 1; i < List.Count; i++)
                if ((List[i] as Student).Rate > (List[numberBest] as Student).Rate)
                    numberBest = i;
            return List[numberBest] as Student;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentCollection group = new StudentCollection();
            group.Add("Steve Jobs", 98);
            group.Add("Larry Page", 89);
            group.Add("Bill Gates", 93);
            group.Add("Mark Zuckerberg", 99);
            group.Add(new Student("Elon Musk", 87));
            foreach (var c in group)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
            Console.WriteLine($"Best student {group.BestStudent()}");
            Console.WriteLine();
            for (int i = 0; i < group.Count; i++)
            {
                Console.WriteLine(group[i]);
            }
            group[2] = new Student("Sergey Brin", 60);
            Console.WriteLine();
            foreach (var c in group)
            {
                Console.WriteLine(c);
            }
            group.Remove(group[2]);
            Console.WriteLine();
            foreach (var c in group)
            {
                Console.WriteLine(c);
            }
            group.RemoveAt(1);
            Console.WriteLine();
            foreach (var c in group)
            {
                Console.WriteLine(c);
            }
        }
    }
}