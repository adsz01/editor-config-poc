using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common.Wallet;
using System;

namespace SB.Customer.Management.Contracts.Output.Wallet.Deposit
{
	public class WalletDepositActivityResult
	{
		public string PartnerTransactionId { get; }
		public Guid SportsbookWalletTransactionId { get; }
		public Guid WalletActivityId { get; }
		public WalletActivityResultCode ActivityResultCode { get; }
		public string ResultNotes { get; }
		public WalletActivityDetails WalletActivityDetails { get; }
		public BetDetails BetDetails { get; }
		public DateTime? ActivityDateTime { get; }
		public string SourceReferenceId { get; private set; }

		[JsonConstructor]
		private WalletDepositActivityResult(
			Guid walletActivityId,
			Guid sportsbookWalletTransactionId,
			string partnerTransactionId,
			WalletActivityResultCode activityResultCode,
			string resultNotes,
			BetDetails betDetails,
			DateTime? activityDateTime,
			WalletActivityDetails walletActivityDetails,
			string sourceReferenceId)
		{
			WalletActivityId = walletActivityId;
			SportsbookWalletTransactionId = sportsbookWalletTransactionId;
			PartnerTransactionId = partnerTransactionId;
			ActivityResultCode = activityResultCode;
			ResultNotes = resultNotes;
			BetDetails = betDetails;
			ActivityDateTime = activityDateTime;
			WalletActivityDetails = walletActivityDetails;
			SourceReferenceId = sourceReferenceId;
		}

		public static WalletDepositActivityResult Create(
			Guid walletActivityId,
			Guid sportsbookTransactionId,
			string partnerTransactionId,
			WalletActivityResultCode activityResultCode,
			string resultNotes,
			BetDetails betDetails = null,
			DateTime? activityDateTime = null,
			WalletActivityDetails walletActivityDetails = null,
			string sourceReferenceId = null)
		{
			return new WalletDepositActivityResult(
				walletActivityId: walletActivityId,
				sportsbookWalletTransactionId: sportsbookTransactionId,
				partnerTransactionId: partnerTransactionId,
				activityResultCode: activityResultCode,
				resultNotes: resultNotes,
				betDetails: betDetails,
				activityDateTime: activityDateTime,
				walletActivityDetails: walletActivityDetails,
				sourceReferenceId: sourceReferenceId);
		}
	}
}
