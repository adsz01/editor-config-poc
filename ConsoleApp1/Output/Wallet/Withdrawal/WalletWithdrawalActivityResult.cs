using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common.Wallet;
using System;

namespace SB.Customer.Management.Contracts.Output.Wallet.Withdrawal
{
	public class WalletWithdrawalActivityResult
	{
		public string PartnerTransactionId { get; }
		public Guid SportsbookWalletTransactionId { get; }
		public Guid WalletActivityId { get; }
		public WalletActivityResultCode ActivityResultCode { get; }
		public string ResultNotes { get; }
		public BetDetails BetDetails { get; }
		public DateTime? ActivityDateTime { get; }
		public WalletActivityDetails WalletActivityDetails { get; }
		public string SourceReferenceId { get; private set; }

		[JsonConstructor]
		private WalletWithdrawalActivityResult(string partnerTransactionId,
			Guid sportsbookWalletTransactionId,
			Guid walletActivityId,
			WalletActivityResultCode activityResultCode,
			string resultNotes,
			BetDetails betDetails,
			DateTime? activityDateTime,
			WalletActivityDetails walletActivityDetails,
			string sourceReferenceId)
		{
			PartnerTransactionId = partnerTransactionId;
			SportsbookWalletTransactionId = sportsbookWalletTransactionId;
			WalletActivityId = walletActivityId;
			ActivityResultCode = activityResultCode;
			ResultNotes = resultNotes;
			BetDetails = betDetails;
			ActivityDateTime = activityDateTime;
			WalletActivityDetails = walletActivityDetails;
			SourceReferenceId = sourceReferenceId;
		}

		public static WalletWithdrawalActivityResult Create(string partnerTransactionId,
			Guid sportsbookWalletTransactionId,
			Guid walletActivityId,
			WalletActivityResultCode activityResultCode,
			string resultNotes,
			BetDetails betDetails = null,
			DateTime? activityDateTime = null,
			WalletActivityDetails walletActivityDetails = null,
			string sourceReferenceId = null)
		{
			return new WalletWithdrawalActivityResult(
				partnerTransactionId: partnerTransactionId,
				sportsbookWalletTransactionId: sportsbookWalletTransactionId,
				walletActivityId: walletActivityId,
				activityResultCode: activityResultCode,
				resultNotes: resultNotes,
				betDetails: betDetails,
				activityDateTime: activityDateTime,
				walletActivityDetails: walletActivityDetails,
				sourceReferenceId: sourceReferenceId);
		}
	}
}
