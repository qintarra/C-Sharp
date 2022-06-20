using System;

namespace InheritanceTask
{
    //Create public class 'Employee' here
    public class Employee
    {
        //Define three private fields: 'name'(string), 'salary'(decimal), 'bonus'(decimal)
        private readonly string name;
        private decimal salary;
        private decimal bonus;
		
        //Define public property 'Name' for getting 'name'
        public string Name
        {
            get
            {
                return name;
            }
        }
		
    }
}

