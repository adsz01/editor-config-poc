using Newtonsoft.Json;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Common.Wallet
{
	public class WalletActivityDetails
	{
		public IEnumerable<FundsApportionment> FundsApportionment { get; }

		[JsonConstructor]
		private WalletActivityDetails(IEnumerable<FundsApportionment> fundsApportionment)
		{
			FundsApportionment = fundsApportionment;
		}

		public static WalletActivityDetails Create(IEnumerable<FundsApportionment> fundsApportionment)
		{
			return new WalletActivityDetails(fundsApportionment);
		}
	}
}
