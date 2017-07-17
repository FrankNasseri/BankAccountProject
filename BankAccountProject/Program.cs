using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MattMurdock client1 = new MattMurdock();
            Checking checking1 = new Checking();
            Saving savings1 = new Saving();

            //Greeting from the cleints bank
            Console.WriteLine("Welcome to the bank of Hell's Kitchen!");
            Console.WriteLine("How may I assist you today?");
            Console.WriteLine("1.View Client Information \n2.View Account Balance \n3.Deposit Funds \n4.Withdraw Funds \n5.Exit");
            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                client1.ClientInfo();
                //Console.WriteLine(client1.Name);
                //Console.WriteLine(client1.Address);
                //Console.WriteLine(client1.AccountNumber);
            }
            else if (userChoice == 2)
            {
                Console.WriteLine("1. Checking \n2. Saving");
                int secondChoice = int.Parse(Console.ReadLine());
                //Console.Clear();
                if (secondChoice == 1)
                {
                    Console.WriteLine(checking1.AccountBalance);
                }
                else if (secondChoice == 2)
                {
                    Console.WriteLine(savings1.AccountBalance);
                }
            }
            else if (userChoice == 3)
            {
                Console.WriteLine("For which account would you like to make a deposit too?");
                Console.WriteLine("1. Checking \n2. Saving");
                int thirdChoice = int.Parse(Console.ReadLine());
                if (thirdChoice == 1)
                {
                    Console.WriteLine("How much would you like to deposit into your Checking Account?");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    checking1.Deposit(deposit);
                    Console.WriteLine("Current Balance: $" + checking1.AccountBalance);
                }
                else if (thirdChoice == 2)
                {
                    Console.WriteLine("How much would you like to deposit into your Savings Account?");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    savings1.Deposit(deposit);
                    Console.WriteLine("Current Balance: $" + savings1.AccountBalance);
                }
            }
            else if (userChoice == 4)
            {
                Console.WriteLine("For which account would you like to make withdraw from?");
                Console.WriteLine("1. Checking \n2. Saving");
                int thirdChoice = int.Parse(Console.ReadLine());
                if (thirdChoice == 1)
                {
                    Console.WriteLine("How much would you like to withdraw from your Checking Account?");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    checking1.Withdraw(withdraw);
                    Console.WriteLine("Current Balance: $" + checking1.AccountBalance);
                }
                else if (thirdChoice == 2)
                {
                    Console.WriteLine("How much would you like to withdraw from your Savings Account?");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    savings1.Withdraw(withdraw);
                    Console.WriteLine("Current Balance: $" + savings1.AccountBalance);
                }
            }

        }
    }
}
