using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common.Wallet;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Wallet.Deposit.V1
{
	public class WalletDepositActivity
	{
		public Guid SportsbookTransactionId { get; }
		public decimal Amount { get; }
		public MoneyType MoneyType { get; }
		public IEnumerable<Fee> Fees { get; }
		public string CurrencyCode { get; }
		public DepositType DepositType { get; }
		public TransactionAction TransactionAction { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public Bet Bet { get; }
		public DateTime ActivityDateTime { get; }
		public string SourceReferenceId { get; }

		[JsonConstructor]
		private WalletDepositActivity(
			decimal amount,
			MoneyType moneyType,
			IEnumerable<Fee> fees,
			string currencyCode,
			DepositType depositType,
			Guid sportsbookTransactionId,
			TransactionAction transactionAction,
			IDictionary<string, string> additionalData,
			Bet bet,
			DateTime activityDateTime,
			string sourceReferenceId = null)
		{
			Amount = amount;
			MoneyType = moneyType;
			Fees = fees;
			CurrencyCode = currencyCode;
			DepositType = depositType;
			SportsbookTransactionId = sportsbookTransactionId;
			TransactionAction = transactionAction;
			AdditionalData = additionalData;
			Bet = bet;
			ActivityDateTime = activityDateTime;
			SourceReferenceId = sourceReferenceId;
		}

		public static WalletDepositActivity Create(
			decimal amount,
			MoneyType moneyType,
			IEnumerable<Fee> fees,
			string currencyCode,
			DepositType depositType,
			Guid sportsbookReferenceId,
			TransactionAction transactionAction,
			IDictionary<string, string> additionalData,
			Bet bet,
			DateTime activityDateTime,
			string sourceReferenceId = null)
		{
			return new WalletDepositActivity(
				amount: amount,
				moneyType: moneyType,
				fees: fees,
				currencyCode: currencyCode,
				depositType: depositType,
				sportsbookTransactionId: sportsbookReferenceId,
				transactionAction: transactionAction,
				additionalData: additionalData,
				bet: bet,
				activityDateTime: activityDateTime,
				sourceReferenceId: sourceReferenceId);
		}
	}
}
