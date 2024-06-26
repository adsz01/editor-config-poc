using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Wallet
{
	public interface IWalletResponse : ICommunityCorrelationResponse
	{
		WalletResponseCode ResponseCode { get; }
		IEnumerable<string> ResponseNotes { get; }
	}
}
