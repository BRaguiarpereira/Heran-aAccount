using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaExemplo.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double loanlimit,double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalnce()
        {
            Balance += Balance * InterestRate;
        }

        // Sobreposto com o override permitindo o withDraw no savingsAccount
        public override void Withdraw(double amount)
        {
            // reaproveita a operacao da superclasse e acrecentar outras coisas depois
            base.Withdraw(amount);
            Balance -= 2.0 ;
        }

    }
}
