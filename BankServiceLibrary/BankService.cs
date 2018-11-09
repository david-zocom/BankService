namespace BankServiceLibrary
{
	public class BankService : IBankService
	{
		private decimal balance = 10000;

		public void Deposit(decimal amount)
		{
			balance += amount;
		}

		public AccountInfo GetAccountInfo()
		{
			return new AccountInfo
			{
				Balance = 72M,
				OwnerName = "David"
			};
		}

		public decimal GetBalance()
		{
			return balance;
		}
	}
}
