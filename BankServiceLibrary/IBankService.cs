using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

		[OperationContract]
		AccountInfo GetAccountInfo();

	}

	[DataContract]
	public class AccountInfo
	{
		[DataMember]
		public string OwnerName { get; set; }

		[DataMember]
		public decimal Balance { get; set; }
	}

}
