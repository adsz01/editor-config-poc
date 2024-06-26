using Newtonsoft.Json;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Wallet.Legacy
{
	public class GetB2CWalletTransactionsResponse
	{
		public IList<B2CWalletTransaction> Payload { get; }
		public bool Authorized { get; }

		[JsonConstructor]
		private GetB2CWalletTransactionsResponse(IList<B2CWalletTransaction> payload, bool authorized)
		{
			Payload = payload;
			Authorized = authorized;
		}

		public static GetB2CWalletTransactionsResponse Create(IList<B2CWalletTransaction> payload, bool authorized)
		{
			return new GetB2CWalletTransactionsResponse(payload, authorized);
		}
	}
}
