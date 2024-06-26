using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common.Wallet;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Wallet.Void.V1
{
	public class WalletVoidActivity
	{
		public Guid WalletActivityIdToVoid { get; }
		public Guid SportsbookTransactionId { get; }
		public TransactionAction TransactionAction { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public DateTime ActivityDateTime { get; }
		public Bet Bet { get; }


		[JsonConstructor]
		private WalletVoidActivity(
			Guid walletActivityIdToVoid,
			Guid sportsbookTransactionId,
			TransactionAction transactionAction,
			IDictionary<string, string> additionalData,
			DateTime activityDateTime,
			Bet bet)
		{
			WalletActivityIdToVoid = walletActivityIdToVoid;
			SportsbookTransactionId = sportsbookTransactionId;
			TransactionAction = transactionAction;
			AdditionalData = additionalData;
			ActivityDateTime = activityDateTime;
			Bet = bet;
		}

		public static WalletVoidActivity Create(
			Guid walletActivityIdToVoid,
			Guid sportsbookTransactionId,
			TransactionAction transactionAction,
			IDictionary<string, string> additionalData,
			DateTime activityDateTime,
			Bet bet)
		{
			return new WalletVoidActivity(
				walletActivityIdToVoid: walletActivityIdToVoid,
				sportsbookTransactionId: sportsbookTransactionId,
				transactionAction: transactionAction,
				additionalData: additionalData,
				activityDateTime: activityDateTime,
				bet: bet);
		}
	}
}
