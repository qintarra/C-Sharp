using System;
using System.Collections.Generic;
using System.Text;

namespace Task_21_3
{
    //Create public class 'Manager' here, which inherits from the 'Employee' class.
    public class Manager : Employee
    {
        //Define closed integer field: 'quantity' (number of clients, who were served by the manager during a month).
        private readonly int quantity;
		
        //Define the constructor with three parameters: 'name'(employee last name), 'salary', and 'clientAmount'(number of served clients). 
        //Assign two first parameters to the base class.
        public Manager(string name, decimal salary, int clientAmount) : base(name, salary)
        {
            quantity = clientAmount;
        }
		
    }
}

