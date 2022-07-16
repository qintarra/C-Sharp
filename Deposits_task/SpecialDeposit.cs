using System;
using System.Collections.Generic;
using System.Text;
namespace Deposits
{
    //Define public class "SpecialDeposit" that inherits from "Deposit".
    public class SpecialDeposit : Deposit
    {
        //Define a constructor that calls the constructor of a base class.
        public SpecialDeposit(decimal amount, int period) : base(amount, period)
        {

        }
		
        //Override method "Income" of base class according to the task.
        public override decimal Income()
        {
            decimal incomeAmount = Amount;

            for (int i = 0; i <= Period; i++)
            {
                incomeAmount += incomeAmount / 100 * i;
            }
            return incomeAmount - Amount;
        }
		
        //Implement interface "IProlongable" in class "SpecialDeposit".
        //Interface's method should return true if deposited more than 1000 UAH.
        public override bool CanToProlong()
        {
            return Amount > 1000;           
        }
    }
}