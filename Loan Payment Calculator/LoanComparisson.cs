using System;
namespace LoanPaymentCalculator
{
	public class LoanComparisson
	{
		private List<Loan> loans;

		public LoanComparisson()
		{
			loans = new List<Loan>();
		}

		public void AddLoan(Loan loan)
		{
			loans.Add(loan);
		}

		public void CompareLoans()
		{
			Console.WriteLine("Loan Comparisson Results:");
			Console.WriteLine("-------------------------------");
            Console.WriteLine();
			Console.WriteLine("The monthly payment for the loans are:");
			Console.WriteLine();


            int counter = 1;
			foreach (Loan loan in loans)
			{
				double monthlyPayment = loan.CalculateLoanPayment();
				Console.WriteLine($"{counter}. Monthly payment is {monthlyPayment}");
				counter++;
			}
		}
	}
}

