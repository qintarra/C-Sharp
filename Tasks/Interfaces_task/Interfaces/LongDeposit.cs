using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class LongDeposit : Deposit
    {
        public LongDeposit(decimal amount, int period) : base(amount, period)
        {

        }
        public override decimal Income()
        {
            decimal a = Amount;

            for (int i = 7; i <= Period; i++)
            {
                a += a * 0.15m;
            }
            return a - Amount;
        }
        public override bool CanToProlong()
        {
            if (Period <= 36)
            {
                return true;
            }
            return false;
        }
    }
}
