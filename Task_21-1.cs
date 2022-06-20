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
		
        //Define public property 'Salary' for getting and setting 'salary'
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
            }
        }
		
        //Define constructor with two parameters: 'name'(string), 'salary'(decimal). Assign parameters to its fields
        public Employee (string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }
		
        

        
    }
}

