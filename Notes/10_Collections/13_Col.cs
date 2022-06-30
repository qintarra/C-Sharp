using System;
using System.Collections;
namespace Collections_13
{
    public class Dog
    {
        public override string ToString()
        {
            return "dog";
        }
    }
    public class Cat
    {
        public override string ToString()
        {
            return "cat";
        }
    }
    public class Elephant
    {
        public override string ToString()
        {
            return "elephant";
        }
    }
    public class Patients : CollectionBase
    {
        public void AdmitPatient(object patient)
        {
            if (patient is Elephant)
                Console.WriteLine("We do not admit elephants!");
            else
                List.Add(patient);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Elephant elf = new Elephant();
            Dog dog = new Dog();
            Patients patients = new Patients();
            patients.AdmitPatient(cat);
            patients.AdmitPatient(elf);
            patients.AdmitPatient(dog);
            foreach (object patient in patients)
            {
                Console.WriteLine($"Patient {patient} admitted");
            }
        }
    }
}