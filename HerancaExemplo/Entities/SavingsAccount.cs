using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaExemplo.Entities
{
    //Classe selada não permite herdala 
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance,double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalnce()
        {
            Balance += Balance * InterestRate;
        }

        // Sobreposto com o override permitindo o withDraw no savingsAccount
        // O Metodo não pode ser sobrescrito em uma outra subclasse porq esta sealed
        public sealed override void Withdraw(double amount)
        {
            // reaproveita a operacao da superclasse e acrecentar outras coisas depois
            base.Withdraw(amount);
            Balance -= 2.0 ;
        }

    }
}
