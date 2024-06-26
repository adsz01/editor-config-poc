using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Output.Wallet.Legacy;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Transaction
{
	public class GetTransactionsResponse : ITransactionResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public TransactionResponseCode ResponseCode { get; }
		public IEnumerable<BetTransactionInfo> BetTransactions { get; }
		public IDictionary<long, GetB2CWalletTransactionsResponse> LegacyTransactionData { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private GetTransactionsResponse(ICorrelationResponse correlationResponse, TransactionResponseCode responseCode, IEnumerable<BetTransactionInfo> betTransactions, IEnumerable<string> responseNotes, IDictionary<long, GetB2CWalletTransactionsResponse> legacyTransactionData)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			BetTransactions = betTransactions;
			ResponseNotes = responseNotes;
			LegacyTransactionData = legacyTransactionData;
		}

		public static GetTransactionsResponse Create(ICorrelationResponse correlationResponse, TransactionResponseCode responseCode, IEnumerable<BetTransactionInfo> betTransactions, IEnumerable<string> responseNotes, IDictionary<long, GetB2CWalletTransactionsResponse> legacyTransactionData)
		{
			return new GetTransactionsResponse(correlationResponse, responseCode, betTransactions, responseNotes, legacyTransactionData);
		}
	}
}
