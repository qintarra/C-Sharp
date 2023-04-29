using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class LongDeposit : Deposit, IProlongable
    {
        public LongDeposit(decimal Amount, int Period) : base(Amount, Period)
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
        public bool CanToProlong()
        {
            return Period <= 36;
        }
    }
}
