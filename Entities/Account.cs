using System;
using System.Collections.Generic;
using System.Text;
using AccountDraw.Entities.Excepitions;

namespace AccountDraw.Entities
{
    class Account
    {
        public int Numer { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }
        public Account() { }

        public Account(int numer, string holder, double balance, double withDrawLimit)
        {
            Numer = numer;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new DomainExceptions("Not enough balance.");
            }
            Balance -= amount;
        }
    }
}
