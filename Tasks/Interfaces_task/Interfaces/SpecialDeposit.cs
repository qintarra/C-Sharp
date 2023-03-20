using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class SpecialDeposit : Deposit
    {
        public SpecialDeposit(decimal amount, int period) : base(amount, period)
        {

        }
        public override decimal Income()
        {
            decimal a = Amount;

            for (int i = 0; i <= Period; i++)
            {
                a += a / 100 * i;
            }
            return a - Amount;
        }
        public override bool CanToProlong()
        {
            if (Amount > 1000m)
            {
                return true;
            }
            return false;
        }
    }
}
