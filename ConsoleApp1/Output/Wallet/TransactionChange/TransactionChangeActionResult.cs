using Newtonsoft.Json;
using System;

namespace SB.Customer.Management.Contracts.Output.Wallet.TransactionChange
{
	public class TransactionChangeActionResult
	{
		public Guid SportsbookTransactionId { get; }
		public string PartnerTransactionId { get; }
		public WalletActivityResultCode ActivityResultCode { get; }
		public string ResultNotes { get; }

		[JsonConstructor]
		private TransactionChangeActionResult(Guid sportsbookTransactionId, 
			string partnerTransactionId, 
			WalletActivityResultCode activityResultCode, 
			string resultNotes)
		{
			SportsbookTransactionId = sportsbookTransactionId;
			PartnerTransactionId = partnerTransactionId;
			ActivityResultCode = activityResultCode;
			ResultNotes = resultNotes;
		}

		public static TransactionChangeActionResult Create(Guid sportsbookTransactionId, 
			string partnerTransactionId, 
			WalletActivityResultCode activityResultCode, 
			string resultNotes)
		{
			return new TransactionChangeActionResult(sportsbookTransactionId, partnerTransactionId, activityResultCode, resultNotes);
		}
	}
}
