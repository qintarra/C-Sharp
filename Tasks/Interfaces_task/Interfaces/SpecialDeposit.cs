using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class SpecialDeposit : Deposit, IProlongable
    {
        public SpecialDeposit(decimal Amount, int Period) : base(Amount, Period)
        {

        }
        public override decimal Income()
        {
            decimal income = Amount;

            for (int i = 0; i <= Period; i++)
            {
                income += income / 100 * i;
            }
            return income - Amount;
        }
        public bool CanToProlong()
        {
            return Amount > 1000;
        }
    }
}
