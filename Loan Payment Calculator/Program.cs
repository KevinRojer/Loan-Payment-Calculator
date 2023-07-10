using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanPaymentCalculator
{
    class Program
    {
        static int MAX_NUMBER_MONTHS = 360;

        static void ShowMenu()
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
                ShowMenu();

                Console.WriteLine("Enter your choice: ");
                string? choice = Console.ReadLine()?.Trim();

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
            }
            
        }
    }
}