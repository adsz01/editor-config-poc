using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Wallet.Deposit
{
	public class WalletDepositResponse : IWalletResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public WalletResponseCode ResponseCode { get; private set; }
		public IEnumerable<WalletDepositActivityResult> WalletDepositActivityResults { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private WalletDepositResponse(
			ICorrelationResponse correlationResponse,
			WalletResponseCode responseCode,
			IEnumerable<WalletDepositActivityResult> walletDepositActivityResults,
			IDictionary<string, string> additionalData,
			IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			WalletDepositActivityResults = walletDepositActivityResults;
			AdditionalData = additionalData;
			ResponseNotes = responseNotes;
		}

		public static WalletDepositResponse Create(
			ICorrelationResponse correlationResponse,
			WalletResponseCode responseCode,
			IEnumerable<WalletDepositActivityResult> walletDepositActivityResults,
			IDictionary<string, string> additionalData,
			IEnumerable<string> responseNotes)
		{
			return new WalletDepositResponse(
				correlationResponse: correlationResponse,
				responseCode: responseCode,
				walletDepositActivityResults: walletDepositActivityResults,
				additionalData: additionalData,
				responseNotes: responseNotes);
		}

		public void WithResponseCode(WalletResponseCode newCode)
		{
			ResponseCode = newCode;
		}
	}
}