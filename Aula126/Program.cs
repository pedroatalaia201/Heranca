using System;
using Aula126.Entities;

namespace Aula126 {
    class Program {
        static void Main(string[] args) {
            BusinessAccount bacc = new BusinessAccount(1001, "Bob", 0.0, 500.00);

            // UPCASTING
            Account acc = bacc; //um BusinessAccount é essencialmente em Account, então isso é possivel;
            Account acc1 = new BusinessAccount(1002, "Mary", 0.0, 200.0);
            Account acc2 = new SavingAccount(1003, "Ana", 0.0, 0.01);

            // DOWNCASTING
            BusinessAccount bacc2 = (BusinessAccount)acc1;
            bacc2.Loan(100.00);

            //BusinessAccount bacc3 = (BusinessAccount)acc2; vai dar erro, pois acc2 é do tipo SavingAccount.
            if (acc2 is BusinessAccount) {
                //BusinessAccount bacc3 = (BusinessAccount)acc2;
                BusinessAccount bacc3 = acc2 as BusinessAccount;//Sintaxe Alternativa;
                bacc3.Loan(200.00);
                Console.WriteLine("Loan!");
            }
            if(acc2 is SavingAccount) {
                SavingAccount acc3 = (SavingAccount)acc2;
                //SavingAccount acc3 = acc2 as SavingAccount; -- Sintaxe Alternativa;
                acc3.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}
