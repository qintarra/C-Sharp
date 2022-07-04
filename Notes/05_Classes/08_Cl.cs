using System;
namespace OOP_4_7_readonly
{
    class Person
    {
        private readonly string firstname;
        private readonly string lastname;
        private readonly int age;

        public Person (string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public void SetFirstName(string firstname)
        {
            //this.firstname = firstname;
        }
    }
}