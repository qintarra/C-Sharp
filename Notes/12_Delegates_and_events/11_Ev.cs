using System;
// An example of the interaction of the event model teacher-student
namespace Event_9
{
    class CheatingEventArgs : EventArgs
    {
        public string Info { get; set; }
        public CheatingEventArgs(string s)
        {
            Info = s;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public Student(string name)
        {
            Name = name;
        }
        public event EventHandler<CheatingEventArgs> StartCheating;
        public void MakeCheating(string s)
        {
            StartCheating?.Invoke(this, new CheatingEventArgs(s));
        }
        public override string ToString()
        {
            return Name;
        }
    }
    class Teacher
    {
        public void AvoidCheating(object sender, CheatingEventArgs e)
        {
            Console.WriteLine("Come tomorrow {0}, you mustn't {1}", sender, e.Info);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Olaf");
            Student s2 = new Student("Xena");
            Teacher t1 = new Teacher();

            s1.StartCheating += t1.AvoidCheating;
            s2.StartCheating += t1.AvoidCheating;
            s1.MakeCheating("use a notes.");
            s2.MakeCheating("use a phone.");
        }
    }
}