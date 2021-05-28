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
            

        }
    }
}
