using System;
using System.Collections.Generic;
using System.Text;

namespace Task_21_2
{
    //Create public class 'SalesPerson' here, which inherits from the 'Employee' class
    public class SalesPerson : Employee
    {
        //Define private integer field: 'percent'
        private readonly int percent;
		
        //Define constructor with three parameters: 'name'(string), 'salary'(decimal) and 'percent'(int). 
        //Assign two first parameters to the base class.
        public SalesPerson(string name, decimal salary, int percent) : base(name, salary)
        {
            this.percent = percent;
        }
		
    }
}
