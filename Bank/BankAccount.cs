using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankAccount
    {
        public string CustomerName { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string customerName, decimal balance)
        {
            CustomerName = customerName;
            Balance = balance;
        }
        public decimal DepositTransaction(decimal deposits)
        {
            Balance += deposits;
            return Balance;        }
        public decimal WithdrawalTransaction(decimal cash)
        {
            Balance -= cash;
            return Balance; 
        }
        public override string ToString()
        {
            return ("Dear " + CustomerName + ", your balance is: " + Balance);
        }
    }
}
