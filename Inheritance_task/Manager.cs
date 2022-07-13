using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
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
		
        //Override public virtual method 'SetBonus', which increases bonus depending on clients amount:
        //if the manager served over 100 clients, his bonus is increased by 500, and if more than 150 clients – by 1000.
        public override void SetBonus(decimal bonus)
        {
            if (quantity > 150)
            {
                bonus += 1000;
            }
            else if (quantity > 100)
            {
                bonus += 500;
            }
            base.SetBonus(bonus);
        }
    }
}

