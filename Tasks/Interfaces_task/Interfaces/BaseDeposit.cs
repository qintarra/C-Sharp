using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    //Define public class "BaseDeposit" that inherits from "Deposit".
    public class BaseDeposit : Deposit
    {
        //Define constructor that calls constructor of a base class.
        public BaseDeposit(decimal Amount, int Period) : base (Amount, Period)
        {
            
        }
		
        //Override method "Income" of base class according to the task.
        public override decimal Income()
        {
            return Amount * (decimal)Math.Pow(1.05, Period) - Amount;
        }
    }
}