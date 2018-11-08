using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BankServiceLibrary
{
	[ServiceContract]
	public interface IBankService
	{
		[OperationContract]
		decimal GetBalance();

		[OperationContract]
		void Deposit(decimal amount);
	}


}
