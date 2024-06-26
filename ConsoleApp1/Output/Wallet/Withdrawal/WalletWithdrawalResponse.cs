using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Wallet.Withdrawal
{
	public class WalletWithdrawalResponse : IWalletResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public WalletResponseCode ResponseCode { get; }
		public IEnumerable<WalletWithdrawalActivityResult> WalletWithdrawalActivityResults { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private WalletWithdrawalResponse(
			ICorrelationResponse correlationResponse,
			WalletResponseCode responseCode,
			IEnumerable<WalletWithdrawalActivityResult> walletWithdrawalActivityResults,
			IDictionary<string, string> additionalData,
			IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			WalletWithdrawalActivityResults = walletWithdrawalActivityResults;
			AdditionalData = additionalData;
			ResponseNotes = responseNotes;
		}

		public static WalletWithdrawalResponse Create(
			ICorrelationResponse correlationResponse,
			WalletResponseCode responseCode,
			IEnumerable<WalletWithdrawalActivityResult> walletWithdrawalActivityResults,
			IDictionary<string, string> additionalData,
			IEnumerable<string> responseNotes) =>
			new WalletWithdrawalResponse(
				correlationResponse: correlationResponse,
				responseCode: responseCode,
				walletWithdrawalActivityResults: walletWithdrawalActivityResults,
				additionalData: additionalData,
				responseNotes: responseNotes);
	}
}