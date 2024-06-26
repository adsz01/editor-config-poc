using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Wallet.Void
{
	public class WalletVoidActivitiesResponse : IWalletResponse
	{
		public WalletResponseCode ResponseCode { get; }
		public ICorrelationResponse CorrelationResponse { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private WalletVoidActivitiesResponse(ICorrelationResponse correlationResponse,
			WalletResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}

		public static WalletVoidActivitiesResponse Create(ICorrelationResponse correlationResponse,
			WalletResponseCode responseCode, IEnumerable<string> responseNotes)
			=> new WalletVoidActivitiesResponse(correlationResponse, responseCode, responseNotes);
	}
}
