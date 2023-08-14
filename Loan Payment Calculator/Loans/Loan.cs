using System;

namespace LoanPaymentCalculator
{
	public class Loan
	{
		private double Principal;
		private double AnnualRate;
		private int NumPeriods;

		public Loan(double amount, double intRate, int term)
		{
			this.Principal = amount;
			this.AnnualRate = intRate / 100;
			this.NumPeriods = term;
		}

		public double CalculateLoanPayment()
		{
			// Calculates monthly payment for Amortization Loans
			double monthlyRate = AnnualRate / 12;
			double monthlyPayment = (Principal * monthlyRate * Math.Pow(1 + monthlyRate, NumPeriods)) / (Math.Pow(1 + monthlyRate, NumPeriods) - 1);
			return monthlyPayment;
		}
	}
}

