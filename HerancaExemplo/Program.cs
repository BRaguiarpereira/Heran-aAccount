using System;
using HerancaExemplo.Entities;
using System.Collections.Generic;
using System.Globalization;
namespace HerancaExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            // criando uma list para uma classe abstrata pode.
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1001, "aliana", 500.00, 400.00));
            list.Add(new SavingsAccount(1001, "bob", 600.00, 0.01));
            list.Add(new BusinessAccount(1001, "aleea", 550.00, 400.00));


            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            // chamada polimorfica que vai fazer açoes em todos elementos
            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("SALDO ATUALIZADO : "
                    + acc.Number
                    + ":"
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("Soma :" + sum.ToString("F2", CultureInfo.InvariantCulture));

            //Account acc = new Account(1011, "Alex", 500.00);
            Account cacc = new SavingsAccount(1011, "Alex", 500.00, 0.01);

            // sacando 10.0

            //acc.Withdraw(10.0);
            cacc.Withdraw(10.0);

            //Console.WriteLine(acc.Balance);
            Console.WriteLine(cacc.Balance);

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);


            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1112, "Anna", 0.0, 400.0);

            // DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                // OUTRA FORMA DE FAZER O CASTING
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalnce();
                Console.WriteLine("Update!");
            }
        }
    }
}
