using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public abstract class Deposit : IComparable<Deposit>, IProlongable
    {
        public decimal Amount { get; }
        public int Period { get; }
        public Deposit(decimal amount, int period)
        {
            Amount = amount;
            Period = period;
        }
        public abstract decimal Income();
        public int CompareTo(Deposit deposit)
        {
            return (Amount + Income()).CompareTo(deposit.Amount + deposit.Income());
        }
        public virtual bool CanToProlong()
        {
           return false;
        }
    }
}
