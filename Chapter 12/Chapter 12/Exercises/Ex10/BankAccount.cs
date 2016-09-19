using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12.Exercises.Ex10
{
    class BankAccount
    {
        public decimal Balance { get; set; }

        public BankAccount(decimal amount)
        {
            if (Balance + amount < 0)
            {
                Balance = 0;
                throw new NegativeException();
            }
            else 
            {
                Balance = amount;
            }
        }

        public void Deposit(decimal value)
        {
            if (value < 0)
                throw new NegativeException();
            else
                Balance += value;
        }

        public void Withdraw(decimal value)
        {
            if (value < 0)
                throw new NegativeException();
            else
                Balance -= value;
        }
    }
}
