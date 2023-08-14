using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanPaymentCalculator
{
    class Program
    {
        private static int MAX_NUMBER_MONTHS = 480;

        static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add a Loan");
            Console.WriteLine("2. Calculate Loan Payment");
            Console.WriteLine("3. Exit.");
            Console.WriteLine();
        }

        public static void Main()
        {
            LoanManager loanManager = new LoanManager();

            while (true)
            {
                DisplayMenu();

                Console.WriteLine("Enter your choice: ");
                Console.WriteLine();

                if(int.TryParse(Console.ReadLine()?.Trim(), out int choice))
                {
                    if (choice == 1)
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
                        loanManager.AddLoan(loan);
                        Console.WriteLine();
                        Console.WriteLine("Loan added successfully.");
                    }
                    else if (choice == 2)
                    {
                        loanManager.CompareLoans();
                        Console.WriteLine();
                        continue;
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Closing application...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please, enter a valid number.");
                        continue;
                    }
                            
                }
                else
                {
                    Console.WriteLine("Invalid input. Please, enter a number.");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bye, bye.");
        }
    }
}