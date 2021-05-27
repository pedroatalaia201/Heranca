using System;

namespace Aula126.Entities {
    class BusinessAccount : Account {
        public double LoanLimit { get; set; }

        public BusinessAccount() { 
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
        : base(number,holder,balance) //usa o construtor de Account
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) {
            if (amount <= LoanLimit)
                Balance += amount;
        }
    }
}
