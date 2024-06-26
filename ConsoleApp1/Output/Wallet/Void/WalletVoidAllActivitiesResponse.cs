using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Wallet.Void
{
	public class WalletVoidAllActivitiesResponse : IWalletResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public WalletResponseCode ResponseCode { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private WalletVoidAllActivitiesResponse(ICorrelationResponse correlationResponse, WalletResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}

		public static WalletVoidAllActivitiesResponse Create(ICorrelationResponse correlationResponse, WalletResponseCode responseCode, IEnumerable<string> responseNotes)
			=> new WalletVoidAllActivitiesResponse(correlationResponse, responseCode, responseNotes);
	}
}