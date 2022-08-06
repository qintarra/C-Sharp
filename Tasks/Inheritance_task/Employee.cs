using System;

namespace Inheritance
{
    //Create public class 'Employee' here
    public class Employee
    {
        //Define three private fields: 'name' (employee last name), money fields - 'salary', 'bonus'.
        private readonly string name;
        private decimal salary;
        private decimal bonus;
		
        //Define public property 'Name' for reading employee’s last name.
        public string Name
        {
            get
            {
                return name;
            }
        }
		
        //Define public property 'Salary' for reading and recording salary field.
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
		
        //Define constructor with two parameters: 'name', 'salary'(last name and salary are set).
        public Employee (string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }
		
        //Define virtual method 'SetBonus' that sets bonuses to salary, amount of which is delegated/conveyed as bonus
        public virtual void SetBonus (decimal bonus)
        {
            this.bonus = bonus;
        }

        //Define method 'ToPay' that returns the summarized salary and bonus value. 
        public decimal ToPay()
        {
            return salary + bonus;
        }
    }
}

