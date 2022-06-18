using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Notes_16_1
{
    class Person
    {
        public string firstname;
        public string lastname;
        public int age;
    }
    class Student : Person
    {
        public string university;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.firstname = "Mark";
            p.lastname = "Zukerberg";
            p.age = 17;
            Console.WriteLine($"I'm {p.firstname} {p.lastname}. I'm {p.age} years old.");

            Student s = new Student();
            s.firstname = "Bill";
            s.lastname = "Gates";
            s.age = 22;
            s.university = "Harvard";
            Console.WriteLine($"I'm {s.firstname} {s.lastname}. I'm {s.age} years old. I study at {s.university}.");

            if (s is Person)
            {
                Console.WriteLine($"Yes, {s.firstname} is a person");
            }
            else
            {
                Console.WriteLine($"No, {s.firstname} isn't a person");
            }
            if (p is Student)
            {
                Console.WriteLine($"Yes, {p.firstname} is a student");
            }
            else
            {
                Console.WriteLine($"No, {p.firstname} isn't a student");
            }
        }
    }
}

using System;
using System.Collections.Generic;
namespace Notes_16_2
{
    class Person
    {
        public string firstname;
        public string lastname;
        public int age;

        public void AboutMe()
        {
            Console.WriteLine($"I'm {firstname} {lastname}. I'm {age} years old.");
        }
    }
    class Student : Person
    {
        public string university;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.firstname = "Mark";
            p.lastname = "Zukerberg";
            p.age = 17;
            p.AboutMe();
            
            Student s = new Student();
            s.firstname = "Bill";
            s.lastname = "Gates";
            s.age = 22;
            s.university = "Harvard";
            s.AboutMe();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Notes_16_3
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

using System;
using System.Collections.Generic;
using System.Text;
namespace Notes_16_4
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Notes_16_5
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
