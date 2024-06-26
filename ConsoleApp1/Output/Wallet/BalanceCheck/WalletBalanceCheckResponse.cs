using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Wallet.BalanceCheck
{
	public class WalletBalanceCheckResponse : IWalletResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public WalletResponseCode ResponseCode { get; }
		public IEnumerable<string> ResponseNotes { get; }
		public IDictionary<string, string> AdditionalData { get; }

		[JsonConstructor]
		private WalletBalanceCheckResponse(ICorrelationResponse correlationResponse, WalletResponseCode responseCode,
			IEnumerable<string> responseNotes, IDictionary<string, string> additionalData)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
			AdditionalData = additionalData;
		}

		public static WalletBalanceCheckResponse Create(ICorrelationResponse correlationResponse, WalletResponseCode responseCode,
			IEnumerable<string> responseNotes, IDictionary<string, string> additionalData)
				=> new WalletBalanceCheckResponse(correlationResponse, responseCode, responseNotes, additionalData);
	}
}
