using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATMProject
    {
        static void Main(string[] args)
        {
            Console.Title = "Open Box Banking Services";

            double balance = 0.00;
            bool repeat = true;
            string accountNumber = "12151991";
            string pinNumber = "1234";
            Console.Write("Please enter your account number: ");
            string userInput = Console.ReadLine();

            while (repeat && userInput != accountNumber)
            {
                for (int failedAttempt = 5; failedAttempt > 0 && userInput != accountNumber; failedAttempt--)
                {
                    Console.Clear();
                    Console.WriteLine("I'm sorry that is an invalid account number");
                    string attempts = failedAttempt > 1 ? "attempts" : "attempt";
                    Console.WriteLine($"You have {failedAttempt} more {attempts}.");
                    Console.Write("Please input correct account number: ");
                    userInput = Console.ReadLine();

                    if (failedAttempt == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Session Terminating");
                        return;

                    }
                }
            }

            Console.Clear();
            Console.Write("Hello Nicholas\nPlease input your PIN number: ");
            repeat = true;
            userInput = Console.ReadLine();

            while (repeat && userInput != pinNumber)
            {
                int failedAttempt;

                for (failedAttempt = 5; failedAttempt > 0 && userInput != pinNumber; failedAttempt--)
                {
                    Console.Clear();
                    Console.WriteLine("I'm sorry that is an invalid pin number");
                    string attempts = failedAttempt > 1 ? "attempts" : "attempt";
                    Console.WriteLine($"You have {failedAttempt} more {attempts}.");
                    Console.Write("Please input correct PIN number :");
                    userInput = Console.ReadLine();

                    if (failedAttempt == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Session Terminating");
                        return;
                    }
                }
            }

            do
            {
                Console.Clear();
                Console.WriteLine($"Your current balance is {balance:$###,###,###,###,###,##0.00}.\n");
                Console.WriteLine("Banking Options:");
                Console.WriteLine("1) Deposit\n2) Withdraw\n3) Exit");


                string userChoice = Console.ReadLine().ToUpper();

                Console.Clear();
                switch (userChoice)
                {
                    case "1":
                    case "DEPOSIT":
                    case "D":
                        Console.Write("How much would you like to DEPOSIT?\n$");
                        double depositAmount = double.Parse(Console.ReadLine());
                        Console.WriteLine($"You have added { depositAmount:c} to account {accountNumber}.");
                        balance = balance + depositAmount;
                        break;
                    case "2":
                    case "WITHDRAW":
                    case "W":
                        Console.Write("How much would you like to WITHDRAW?\n$");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        balance = balance - withdrawAmount;
                        Console.WriteLine($"You have withdrawn {withdrawAmount:$###,###,##0.00} from account {accountNumber}");
                        break;
                    case "3":
                    case "E":
                    case "EXIT":
                        Console.WriteLine("Thank you for banking with us Today!");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("That was not a valid option.\nPlease try again.\nPress any key to return back to the main menu...");
                        Console.ReadKey(false);
                        break;
                }
            } while (repeat == true);
        }//End Main()
    }//End Class
}//End Namespace
