using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Client
    {
        private readonly Deposit[] deposits;
        public Client()
        {
            deposits = new Deposit[10];
        }
        public bool AddDeposit(Deposit deposit)
        {
            for (int i = 0; i < 10; i++)
            {
                if (deposits[i] == null)
                {
                    deposits[i] = deposit;
                    return true;
                }
            }
            return false;
        }
        public decimal TotalIncome()
        {
            decimal sum = 0;

            for (int i = 0; i < 10; i++)
            {
                if (deposits[i] != null)
                {
                    sum += deposits[i].Income();
                }
            }
            return sum;
        }
        public decimal MaxIncome()
        {
            decimal max = 0;

            for (int i = 0; i < 10; i++)
            {
                if (deposits[i] != null && max < deposits[i].Income())
                    max = deposits[i].Income();
            }
            return max;
        }
        public decimal GetIncomeByNumber(int i)
        {
            if (deposits[i - 1] != null)
            {
                return deposits[i - 1].Income();
            }
            else
            {
                return 0;
            }
        }

        }
    }
}
