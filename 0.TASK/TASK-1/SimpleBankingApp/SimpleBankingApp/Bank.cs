using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBankingApp
{
    class Bank
    {

        #region variable declaration
        public readonly string bankName;
        public const double MinBalance = 100.0;
        #endregion

        #region Constructor
        public Bank(string bankName)
        {
            this.bankName = bankName;
        }
        #endregion

        #region Account declaration
        public static Account account = new Account
        {
            AccountNumber = "12345",
            Name = "Thillai",
            Balance = 50000
        };
        #endregion

        #region Login Validation
        public bool Login(string accNumber)
        {
            return string.Equals(account.AccountNumber, accNumber);
        }
        #endregion

        #region Show AccountDetails
        public void ViewAccountDetails()
        {
            Console.WriteLine($"---------------------------------------------------");
            Console.WriteLine($"Bank Name      : {bankName}");
            Console.WriteLine($"Account Number : {account.AccountNumber}");
            Console.WriteLine($"Account Name   : {account.Name}");
            Console.WriteLine($"Account Balance: {account.Balance}");
            Console.WriteLine($"---------------------------------------------------");
            Console.WriteLine();
        }
        #endregion

        #region Deposit
        public void Deposit()
        {
            Console.WriteLine($"---------------------------------------------------");
            Console.Write("Enter The Deposit Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if(amount > 0)
            {
                account.Balance += amount;
                Console.WriteLine($"Deposited ₹{amount}. New Balance: ₹{account.Balance}");
            }
            else
            {
                Console.WriteLine("Enter The Correct Amount");
            }
            Console.WriteLine($"---------------------------------------------------");
            Console.WriteLine();
        }
        #endregion

        #region Withdraw
        public void Withdraw()
        {
            Console.WriteLine($"---------------------------------------------------");
            Console.Write($"Enter The Amunt To Withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if(amount <= account.Balance && (account.Balance - amount) >= MinBalance )
            {
                account.Balance -= amount;
                Console.WriteLine($"Withdrawn ₹{amount}. New Balance: ₹{account.Balance}");
            }
            else
            {
                Console.WriteLine("Cannot withdraw.");
            }
            Console.WriteLine($"---------------------------------------------------");
            Console.WriteLine();
        }
        #endregion



    }
}
