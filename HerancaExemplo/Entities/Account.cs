using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaExemplo.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        // Protected permite a modificação do saldo  Balance em uma Subclasse no caso.
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // Sobreposto com o metodo virtual 
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }
        public void Deposit(double amount)
        {
            Balance += amount;        }
    }
}
