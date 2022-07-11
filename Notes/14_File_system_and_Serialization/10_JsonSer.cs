using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

//You need to add an assembly to the project System.Runtime.Serialization.dll

namespace Serialization_Json
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        public Person(string name, int year)
        {
            Name = name;
            Age = year;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //object to serialize
            Person person1 = new Person("Tom", 25);
            Person person2 = new Person("Jerry", 22);
            Person[] people = new Person[] { person1, person2 };

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Person[]));

            using(FileStream fs = new FileStream(@"C:\Demo\People.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, people);
            }

            using (FileStream fs = new FileStream(@"C:\Demo\People.json", FileMode.OpenOrCreate))
            {
                Person[] newpeople = (Person[])jsonFormatter.ReadObject(fs);
                foreach (Person p in newpeople)
                {
                    Console.WriteLine("Name: {0} --- Age: {1}", p.Name, p.Age);
                }
            }
        }
    }
}