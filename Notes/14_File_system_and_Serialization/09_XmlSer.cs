using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace XmlSerialization_1
{
    public class Employee
    {
        public string Name;
        public int Age;
    }
    public class Company
    {
        [XmlAttribute]
        public string CompanyName;

        [XmlElement(ElementName = "Members")]
        public Employee[] Employees;
    }
    class Program
    {
        static void Main()
        {
            string filename = @"C:\Demo\Company.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(Company));
            TextWriter writer = new StreamWriter(filename);
            Company com = new Company();
            com.CompanyName = "D-Systems";
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            emp1.Name = "Peter";
            emp1.Age = 42;
            emp2.Name = "Jackson";
            emp2.Age = 37;
            com.Employees = new Employee[2] { emp1, emp2 };
            serializer.Serialize(writer, com);
            writer.Close();

            FileStream fs = new FileStream(filename, FileMode.Open);
            Company cmp = (Company)serializer.Deserialize(fs);
            Console.WriteLine(cmp.CompanyName);
            foreach (Employee e in cmp.Employees)
            {
                Console.WriteLine("{0} {1}", e.Name, e.Age);
            }
        }
    }
}