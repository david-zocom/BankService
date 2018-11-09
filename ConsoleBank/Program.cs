using System;
using ConsoleBank.BankServiceReference;

namespace ConsoleBank
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the bank");
			using (BankServiceClient proxy = new BankServiceClient())
			{
				decimal value = proxy.GetBalance();
				Console.WriteLine("The account balance is " + value);

				proxy.Deposit(400);
				value = proxy.GetBalance();
				Console.WriteLine("We deposited some money, and the new balance is " + value);

				AccountInfo info = proxy.GetAccountInfo();
				Console.WriteLine("Account is owned by " + info.OwnerName
					+ " and has " + info.Balance + " money.");
			}

			Console.WriteLine("Press any key to exit");
			Console.ReadKey();
		}
	}
}
