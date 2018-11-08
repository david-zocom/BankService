namespace BankServiceLibrary
{
	public class BankService : IBankService
	{
		private decimal balance = 10000;

		public void Deposit(decimal amount)
		{
			balance += amount;
		}

		public decimal GetBalance()
		{
			return balance;
		}
	}
}
