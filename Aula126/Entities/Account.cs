﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula126.Entities {
    class Account {
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

        public void Withdraw(double amount) {
            Balance -= amount + 5.00;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
    }
}
