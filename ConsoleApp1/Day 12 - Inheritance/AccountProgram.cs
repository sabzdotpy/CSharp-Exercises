using ConsoleApp1.Day_11____Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum AccountType
{
    Savings,
    Current
}

namespace ConsoleApp1.Day_12___Inheritance
{
    class BankAccount
    {

        private int balance = 0;
        private AccountType accountType = AccountType.Savings;
        private int accountNumber = 0;

        public BankAccount(AccountType accountType = AccountType.Savings)
        {
            this.balance = 0;
            this.accountType = accountType;
            this.accountNumber = new Random().Next(1, 99999);
        }

        public int Deposit(int amount)
        {
            Console.WriteLine($"Depositing Rs.{amount} to Acc {this.accountNumber}");
            this.balance += amount;
            return this.balance;
        }

        public int Withdraw(int amount)
        {
            if (this.balance < amount)
            {
                Console.WriteLine($"Withdrawl request failed for Rs.{amount}, Acc: {this.accountNumber}.");
                throw new Exception("Insufficient funds.");
            }

            Console.WriteLine($"Withdrawl Succeeded for Rs.{amount}, Acc: {this.accountNumber}");
            this.balance -= amount;
            return this.balance;
        }

    }
}
