using System;
using System.Globalization;
using System.Collections.Generic;
using Aula126.Entities;

namespace Aula126 {
    class Program {
        static void Main(string[] args) {
            List<Account> list = new List<Account>();           

            list.Add(new SavingAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double soma = 0.0;

            foreach(Account acc in list)
            {
                soma += acc.Balance; 
            }

            Console.WriteLine("Total $ " + soma.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in list)
            {
                acc.Withdraw(10.0);
                Console.WriteLine("Update account " + acc.Number + " : " + 
                    acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
