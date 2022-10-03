using System;
using System.Linq;

namespace Bank
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] c = Console.ReadLine().Split(',');
            BankAccount cus = new BankAccount(c[0], decimal.Parse(c[1]));
            int input = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < input; i++)
            {
                string[] n = Console.ReadLine().Split(": ");
                if (n[0] == "Deposit")
                {
                    cus.DepositTransaction(decimal.Parse(n[1]));
                }
                else if (n[0] == "Withdrawal")
                {
                    cus.WithdrawalTransaction(decimal.Parse(n[1]));
                }
            }
            Console.WriteLine($"Dear {cus.CustomerName}, your balance is: {cus.Balance}");
        }
    }
}
