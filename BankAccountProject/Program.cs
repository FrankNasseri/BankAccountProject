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
            string userChoice;
            string secondChoice;
            string thirdChoice;
            string fourthChoice;

            //Greeting from the cleints bank
            do
            {
                Console.WriteLine("Welcome to the bank of Hell's Kitchen!");
                Console.WriteLine("How may I assist you today?");
                Console.WriteLine("1.View Client Information \n2.View Account Balance \n3.Deposit Funds \n4.Withdraw Funds \n5.Exit");
                userChoice = Console.ReadLine();
                Console.Clear();
                if (userChoice == "1")
                {
                    client1.ClientInfo();
                    Console.WriteLine("Press enter when finished");
                    Console.ReadLine();
                    //Console.Clear();
                }
                if (userChoice == "2")
                {
                    do
                    {
                        Console.WriteLine("1. Checking \n2. Saving \n3. Back \n4. Exit");
                        secondChoice = Console.ReadLine();
                        Console.Clear();
                        if (secondChoice == "1")
                        {
                            checking1.CheckBalance();
                        }
                        if (secondChoice == "2")
                        {
                            savings1.CheckBalance();
                        }
                        if (secondChoice == "3")
                        {
                            break;
                        }
                        if (secondChoice == "4")
                        {
                            userChoice = "5";
                            break;
                        }
                    } while (secondChoice != "1" || secondChoice != "2" || secondChoice != "3" || secondChoice != "4");
                }
                if (userChoice == "3")
                {
                    do
                    {
                        Console.WriteLine("For which account would you like to make a deposit too?");
                        Console.WriteLine("1. Checking \n2. Saving \n3. Back \n4. Exit");
                        thirdChoice = Console.ReadLine();
                        Console.Clear();
                        if (thirdChoice == "1")
                        {
                            Console.WriteLine("How much would you like to deposit into your Checking Account?");
                            double deposit = Convert.ToDouble(Console.ReadLine());
                            checking1.Deposit(deposit);
                            Console.WriteLine("Current Balance: $" + checking1.AccountBalance);
                            Console.WriteLine("Press enter when finished");
                            Console.ReadLine();
                            //Console.Clear();
                        }
                        if (thirdChoice == "2")
                        {
                            Console.WriteLine("How much would you like to deposit into your Savings Account?");
                            double deposit = Convert.ToDouble(Console.ReadLine());
                            savings1.Deposit(deposit);
                            Console.WriteLine("Current Balance: $" + savings1.AccountBalance);
                            Console.WriteLine("Press enter when finished");
                            Console.ReadLine();
                            //Console.Clear();
                        }
                        if (thirdChoice == "3")
                        {
                            break;
                        }
                        if (thirdChoice == "4")
                        {
                            userChoice = "5";
                            break;
                        }
                    } while (thirdChoice != "1" || thirdChoice != "2" || thirdChoice != "3" || thirdChoice != "4");
                }
                if (userChoice == "4")
                {
                    do
                    {
                        Console.WriteLine("For which account would you like to make withdraw from?");
                        Console.WriteLine("1. Checking \n2. Saving\n3. Back \n4. Exit");
                        fourthChoice = Console.ReadLine();
                        Console.Clear();
                        if (fourthChoice == "1")
                        {
                            Console.WriteLine("How much would you like to withdraw from your Checking Account?");
                            double withdraw = Convert.ToDouble(Console.ReadLine());
                            checking1.Withdraw(withdraw);
                            Console.WriteLine("Current Balance: $" + checking1.AccountBalance);
                            Console.WriteLine("Press enter when finished");
                            Console.ReadLine();
                            //Console.Clear();
                        }
                        if (fourthChoice == "2")
                        {
                            Console.WriteLine("How much would you like to withdraw from your Savings Account?");
                            double withdraw = Convert.ToDouble(Console.ReadLine());
                            if (withdraw > savings1.AccountBalance)
                            {
                                Console.WriteLine("I'm sorry, but you do not have sufficient funds for that transaction!");
                                Console.WriteLine("Press enter when finished");
                                Console.ReadLine();
                                //Console.Clear();
                                break;
                            }
                            if (withdraw <= savings1.AccountBalance)
                            {
                                savings1.Withdraw(withdraw);
                                Console.WriteLine("Current Balance: $" + savings1.AccountBalance);
                                Console.WriteLine("Press enter when finished");
                                Console.ReadLine();
                                //Console.Clear();
                            }
                            if (fourthChoice == "3")
                            {
                                break;
                            }
                            if (fourthChoice == "4")
                            {
                                userChoice = "5";
                                break;
                            }
                        }
                    } while (fourthChoice != "1" || fourthChoice != "2" || fourthChoice != "3" || fourthChoice != "4");
                }
            } while (userChoice != "5");

            Console.WriteLine("We appreciate your business here at The Bank of Hell's Kitchen");
            Console.WriteLine("Have a great day and watch out for that DareDevil guy!");

        }
    }
}




