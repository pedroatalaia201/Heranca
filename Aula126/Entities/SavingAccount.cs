using System;

namespace Aula126.Entities {
    class SavingAccount : Account {
        public double InterestRate { get; set; }

        public SavingAccount() {
        }

        public SavingAccount(int number, string holder, double balance, double interstRate) 
        : base(number, holder, balance){
            InterestRate = interstRate;
        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }
        /*
        //override sobescreve o método;
        public override void Withdraw(double amount) {
            Balance -= amount;
        }
        */
        public override void Withdraw(double amount) {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
