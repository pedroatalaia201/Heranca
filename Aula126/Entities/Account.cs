using System;
using System.Collections.Generic;
using System.Text;

namespace Aula126.Entities {
    abstract class Account {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }
        //protected permite que subclasses acessem esse atributo;

        public Account() {
        }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        //virtual permite que o método seja sobrescrito;
        public virtual void Withdraw(double amount) {
            Balance -= amount + 5.00;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
    }
}
