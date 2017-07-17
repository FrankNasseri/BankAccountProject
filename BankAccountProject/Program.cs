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
            while (true)
            {
                Console.WriteLine("Welcome to the bank of Hell's Kitchen!");
                Console.WriteLine("How may I assist you today?");
                Console.WriteLine("1.View Client Information \n2.View Account Balance \n3.Deposit Funds \n4.Withdraw Funds \n5.Exit");
                int userChoice = int.Parse(Console.ReadLine());
                Console.Clear();
                if (userChoice == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Client Information\n6. Exit");
                        int firstChoice = int.Parse(Console.ReadLine());
                        if (firstChoice == 1)
                        {
                            client1.ClientInfo();
                        }
                        else if (firstChoice == 6)
                        {
                            return;
                        }
                    }
                }
                else if (userChoice == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Checking \n2. Saving \n3. Exit");
                        int secondChoice = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (secondChoice == 1)
                        {
                            checking1.CheckBalance();
                        }
                        else if (secondChoice == 2)
                        {
                            savings1.CheckBalance();
                        }
                        else if (secondChoice == 3)
                        {
                            break;
                        }
                    }
                }
                else if (userChoice == 3)
                {
                    while (true)
                    {
                        Console.WriteLine("For which account would you like to make a deposit too?");
                        Console.WriteLine("1. Checking \n2. Saving \n3. Exit");
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
                        else if (thirdChoice == 3)
                        {
                            break;
                        }
                    }
                }
                else if (userChoice == 4)
                {
                    while (true)
                    {
                        Console.WriteLine("For which account would you like to make withdraw from?");
                        Console.WriteLine("1. Checking \n2. Saving\n3. Exit");
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
                            if (withdraw > savings1.AccountBalance)
                            {
                                Console.WriteLine("I'm sorry, but you do not have sufficient funds for that transaction!");
                            }
                            else if (withdraw <= savings1.AccountBalance)
                            {
                                savings1.Withdraw(withdraw);
                                Console.WriteLine("Current Balance: $" + savings1.AccountBalance);
                            }
                        }
                        else if (thirdChoice == 3)
                        {
                            break;
                        }
                    }
                }
                else if (userChoice == 5)
                {
                    Console.WriteLine("We appreciate your business here at The Bank of Hell's Kitchen");
                    Console.WriteLine("Have a great day and watch out for that DareDevil guy!");
                }
                    return;
                }
            }
        }
    }
