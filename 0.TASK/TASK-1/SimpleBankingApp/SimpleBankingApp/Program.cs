using System;

namespace SimpleBankingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank bank = new Bank("Code Bank");

            Console.WriteLine("===Welcome To Code Bank===");
            Console.Write("Enter Your Account Number: ");
            string accNumber = Console.ReadLine();

            if(bank.Login(accNumber))
            {
                while(true)
                {
                    Console.WriteLine(" 1.View Account \n 2.Deposit \n 3.Withdraw \n 4.Exit");
                    Console.Write("Select Option: ");
                    string option = Console.ReadLine();

                    switch(option)
                    {
                        case "1":
                            bank.ViewAccountDetails();
                            break;
                        case "2":
                            bank.Deposit();
                            break;
                        case "3":
                            bank.Withdraw();
                            break;
                        case "4":
                            return;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }

                }
                
            }
            else
            {
                Console.WriteLine("Account Number Not Exists..");
            }


        }
    }
}
