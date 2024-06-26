using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Wallet.TransactionChange
{
	public class TransactionChangeResponse : IWalletResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public WalletResponseCode ResponseCode { get; }
		public IEnumerable<TransactionChangeActionResult> TransactionActionChangeResults { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private TransactionChangeResponse(ICorrelationResponse correlationResponse, WalletResponseCode responseCode,
			IEnumerable<TransactionChangeActionResult> transactionActionChangeResults,
			IDictionary<string, string> additionalData, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			TransactionActionChangeResults = transactionActionChangeResults;
			AdditionalData = additionalData;
			ResponseNotes = responseNotes;
		}

		public static TransactionChangeResponse Create(ICorrelationResponse correlationResponse, WalletResponseCode responseCode,
			IEnumerable<TransactionChangeActionResult> transactionActionChangeResults,
			IDictionary<string, string> additionalData, IEnumerable<string> responseNotes)
				=> new TransactionChangeResponse(correlationResponse, responseCode, transactionActionChangeResults,
					additionalData, responseNotes);
	}
}
