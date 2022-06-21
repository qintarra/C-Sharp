using System;
using System.Collections.Generic;
using System.Text;

namespace Task_21_2
{
    //Create public class 'SalesPerson' here, which inherits from the 'Employee' class.
    public class SalesPerson : Employee
    {
        //Define private integer field: 'percent' (percent of sales targets plan performance/execution).
        private readonly int percent;
		
        //Define constructor with three parameters: 'name'(string) (employee last name), 'salary'(decimal) and 'percent'(int) (percent of plan performance). 
        //Assign two first parameters to the base class.
        public SalesPerson(string name, decimal salary, int percent) : base(name, salary)
        {
            this.percent = percent;
        }
		
        //Override public virtual method 'SetBonus', which increases bonus depending on percent.
        //If the salesperson completed the plan more than 100%, his bonus is doubled (is multiplied by 2), 
        //and if it more than 200% - the bonus is tripled (is multiplied by 3).
        public override void SetBonus(decimal bonus)
        {
            if(percent > 200)
            {
                bonus *= 3;
            }
            else if(percent > 100)
            {
                bonus *= 2;
            }
            base.SetBonus(bonus);
        }
    }
}
