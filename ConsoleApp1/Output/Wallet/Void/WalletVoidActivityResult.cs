using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common.Wallet;
using System;

namespace SB.Customer.Management.Contracts.Output.Wallet.Void
{
	public class WalletVoidActivityResult
	{
		public Guid WalletVoidActivityId { get; }
		public Guid WalletActivityId { get; }
		public string PartnerTransactionId { get; }
		public Guid SportsbookWalletTransactionId { get; }
		public WalletActivityResultCode ResultCode { get; }
		public string ResultNotes { get; }
		public VoidedActivityDetails VoidedActivityDetails { get; }
		public WalletActivityDetails WalletActivityDetails { get; }

		[JsonConstructor]
		private WalletVoidActivityResult(Guid walletVoidActivityId, Guid walletActivityId, WalletActivityResultCode resultCode,
			string resultNotes, string partnerTransactionId, Guid sportsbookWalletTransactionId, VoidedActivityDetails voidedActivityDetails,
			WalletActivityDetails walletActivityDetails)
		{
			WalletVoidActivityId = walletVoidActivityId;
			WalletActivityId = walletActivityId;
			ResultCode = resultCode;
			ResultNotes = resultNotes;
			PartnerTransactionId = partnerTransactionId;
			SportsbookWalletTransactionId = sportsbookWalletTransactionId;
			VoidedActivityDetails = voidedActivityDetails;
			WalletActivityDetails = walletActivityDetails;
		}

		public static WalletVoidActivityResult Create(Guid walletVoidActivityId, Guid walletActivityId, WalletActivityResultCode resultCode,
			string resultNotes, string partnerTransactionId, Guid sportsbookWalletTransactionId, VoidedActivityDetails voidedActivityDetails = null,
			WalletActivityDetails walletActivityDetails = null) =>
			new WalletVoidActivityResult(walletVoidActivityId, walletActivityId, resultCode, resultNotes, partnerTransactionId,
				sportsbookWalletTransactionId, voidedActivityDetails, walletActivityDetails);
	}
}