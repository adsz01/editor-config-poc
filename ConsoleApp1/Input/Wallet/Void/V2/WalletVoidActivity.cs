using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common.Wallet;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Wallet.Void.V2
{
	public class WalletVoidActivity
	{
		public Guid WalletActivityIdToVoid { get; }
		public Guid SportsbookTransactionId { get; }
		public TransactionAction TransactionAction { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public DateTime ActivityDateTime { get; }
		public decimal CurrentExchangeRate { get; }
		public string BaseCurrencyCode { get; }
		public Bet Bet { get; }


		[JsonConstructor]
		private WalletVoidActivity(
			Guid walletActivityIdToVoid,
			Guid sportsbookTransactionId,
			TransactionAction transactionAction,
			IDictionary<string, string> additionalData,
			DateTime activityDateTime,
			decimal currentExchangeRate,
			string baseCurrencyCode,
			Bet bet)
		{
			WalletActivityIdToVoid = walletActivityIdToVoid;
			SportsbookTransactionId = sportsbookTransactionId;
			TransactionAction = transactionAction;
			AdditionalData = additionalData;
			ActivityDateTime = activityDateTime;
			CurrentExchangeRate = currentExchangeRate;
			BaseCurrencyCode = baseCurrencyCode;
			Bet = bet;
		}

		public static WalletVoidActivity Create(
			Guid walletActivityIdToVoid,
			Guid sportsbookTransactionId,
			TransactionAction transactionAction,
			IDictionary<string, string> additionalData,
			DateTime activityDateTime,
			decimal currentExchangeRate,
			string baseCurrencyCode,
			Bet bet)
		{
			return new WalletVoidActivity(
				walletActivityIdToVoid: walletActivityIdToVoid,
				sportsbookTransactionId: sportsbookTransactionId,
				transactionAction: transactionAction,
				additionalData: additionalData,
				activityDateTime: activityDateTime,
				currentExchangeRate: currentExchangeRate,
				baseCurrencyCode: baseCurrencyCode,
				bet: bet);
		}
	}
}
