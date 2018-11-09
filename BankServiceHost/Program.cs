using System;
using System.ServiceModel;
using BankServiceLibrary;

namespace BankServiceHost
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the bank service host");
			// Kom ihåg att köra VS som administratör, annars kan inte VS öppna en port åt servicen
			using (ServiceHost host = new ServiceHost(typeof(BankService)))
			{
				host.Open();

				// URL är den som vi skrivit i App.config
				const string url = "http://localhost:8733/BankServiceHost/";
				Console.WriteLine("Service is running on URL " + url);
				Console.WriteLine("Press enter to terminate service.");
				Console.ReadLine();
				host.Close();
			}
		}
	}
}
