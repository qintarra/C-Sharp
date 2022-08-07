using System;
using System.Collections.Generic;
using System.Text;

namespace Deposit
{
    //Define public class "LongDeposit" that inherits from "Deposit".
    public class LongDeposit : Deposit, IProlongable
    {
        ////Define a constructor that calls the constructor of a base class.
        public LongDeposit(decimal amount, int period) : base(amount, period)
        {

        }
		
        //Override method "Income" of base class according to the task.
        public override decimal Income()
        {
            if (Period > 6)
            {
                return Amount * (decimal)(Math.Pow((1.15), (Period - 6))) - Amount;
            }
            return 0;
        }
		
        //Implement interface "IProlongable" in class "LongDeposit".
        //Interface's method should return true if the deposit term was no more than 3 years.
        public override bool CanToProlong()
        {
            return Period <= 36; //3 years == 36 month
        }
    }
}