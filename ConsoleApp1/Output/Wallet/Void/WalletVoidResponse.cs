using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Wallet.Void
{
	public class WalletVoidResponse : IWalletResponse
	{
		public WalletResponseCode ResponseCode { get; }

		public ICorrelationResponse CorrelationResponse { get; }
		public IEnumerable<string> ResponseNotes { get; }
		public IEnumerable<WalletVoidActivityResult> WalletVoidActivityResults { get; }

		[JsonConstructor]
		private WalletVoidResponse(ICorrelationResponse correlationResponse, IEnumerable<WalletVoidActivityResult> walletVoidActivityResults,
			WalletResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			WalletVoidActivityResults = walletVoidActivityResults;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}

		public static WalletVoidResponse Create(ICorrelationResponse correlationResponse, IEnumerable<WalletVoidActivityResult> walletVoidActivityResults,
			WalletResponseCode responseCode, IEnumerable<string> responseNotes)
				=> new WalletVoidResponse(correlationResponse, walletVoidActivityResults, responseCode, responseNotes);
	}
}
