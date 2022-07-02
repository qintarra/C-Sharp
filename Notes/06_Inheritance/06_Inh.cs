using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_7_4
{
    class Person
    {
        public string firstname;
        public string lastname;
        public int age;

        public override string ToString()
        {
            return string.Format($"{firstname} {lastname} {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            double y = 2.5;
            string s = "Hello!";
            Person p = new Person();
            p.firstname = "Bill";
            p.lastname = "Gates";
            p.age = 22;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(s);
            Console.WriteLine(p);
        }
    }
}