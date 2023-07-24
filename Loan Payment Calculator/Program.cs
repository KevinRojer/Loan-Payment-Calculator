using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanPaymentCalculator
{
    class Program
    {
        static private int MAX_NUMBER_MONTHS = 360;

        private static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Single Loan Payment");
            Console.WriteLine("2. Loan Comparisson");
            Console.WriteLine("3. Exit.");
            Console.WriteLine();
        }

        public static void Main()
        {
            while (true)
            {
                DisplayMenu();

                Console.WriteLine("Enter your choice: ");
                string? choice = Console.ReadLine()?.Trim();
                Console.WriteLine();

                if (string.IsNullOrWhiteSpace(choice))
                {
                    Console.WriteLine("Invalid input. Please, try again.");
                }
                else if (choice == "1")
                {
                    Console.WriteLine("Enter loan amount: ");
                    if (!double.TryParse(Console.ReadLine(), out double loanAmont) || loanAmont <= 0)
                    {
                        Console.WriteLine("Invalid loan amount. Please, try again.");
                        continue;
                    }

                    Console.WriteLine("Enter interest rate (0 - 100%): ");
                    if (!double.TryParse(Console.ReadLine(), out double intRate) || intRate < 0 || intRate > 100)
                    {
                        Console.WriteLine("Invalid input. Please, enter a valid interest rate between 0 and 100.");
                        continue;
                    }

                    Console.WriteLine("Enter loan term (in months): ");
                    if (!int.TryParse(Console.ReadLine(), out int loanTerm) || loanTerm <= 0 || loanTerm > MAX_NUMBER_MONTHS)
                    {
                        Console.WriteLine("Invalid input. Please, enter a positive loan term in months.");
                        continue;
                    }

                    Loan loan = new Loan(loanAmont, intRate, loanTerm);
                    double monthlyPayment = loan.CalculateLoanPayment();
                    Console.WriteLine();
                    Console.WriteLine($"Your monthly payment is {monthlyPayment:C2}");

                }
                else if (choice == "2")
                {
                    Console.WriteLine("Number of loans to compare: ");

                }
                else if (choice == "3")
                {
                    Console.WriteLine("Application closed.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please, try again.");
                }

                Console.WriteLine();
            }
            
        }
    }
}