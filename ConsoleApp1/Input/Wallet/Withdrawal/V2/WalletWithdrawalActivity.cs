using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common.Wallet;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Wallet.Withdrawal.V2
{
	public class WalletWithdrawalActivity
	{
		public decimal Amount { get; }
		public MoneyType MoneyType { get; }
		public IEnumerable<Fee> Fees { get; }
		public string CurrencyCode { get; }
		public WithdrawalType WithdrawalType { get; }
		public TransactionAction TransactionAction { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public Bet Bet { get; }
		public Guid SportsbookWalletTransactionId { get; }
		public DateTime ActivityDateTime { get; }
		public decimal CurrentExchangeRate { get; }
		public string BaseCurrencyCode { get; }
		public string SourceReferenceId { get; }

		[JsonConstructor]
		private WalletWithdrawalActivity(
			decimal amount,
			MoneyType moneyType,
			string currencyCode,
			WithdrawalType withdrawalType,
			IEnumerable<Fee> fees,
			TransactionAction transactionAction,
			IDictionary<string, string> additionalData,
			Bet bet,
			Guid sportsbookWalletTransactionId,
			DateTime activityDateTime,
			decimal currentExchangeRate,
			string baseCurrencyCode,
			string sourceReferenceId = null)
		{
			Amount = amount;
			MoneyType = moneyType;
			CurrencyCode = currencyCode;
			WithdrawalType = withdrawalType;
			Fees = fees;
			TransactionAction = transactionAction;
			AdditionalData = additionalData;
			Bet = bet;
			SportsbookWalletTransactionId = sportsbookWalletTransactionId;
			ActivityDateTime = activityDateTime;
			CurrentExchangeRate = currentExchangeRate;
			BaseCurrencyCode = baseCurrencyCode;
			SourceReferenceId = sourceReferenceId;
		}

		public static WalletWithdrawalActivity Create(
			decimal amount,
			MoneyType moneyType,
			string currencyCode,
			WithdrawalType withdrawalType,
			IEnumerable<Fee> fees,
			TransactionAction transactionAction,
			IDictionary<string, string> additionalData,
			Bet bet,
			Guid sportsbookWalletTransactionId,
			DateTime activityDateTime,
			decimal currentExchangeRate,
			string baseCurrencyCode,
			string sourceReferenceId = null) =>
			new WalletWithdrawalActivity(
				amount: amount,
				moneyType: moneyType,
				currencyCode: currencyCode,
				withdrawalType: withdrawalType,
				fees: fees,
				transactionAction: transactionAction,
				additionalData: additionalData,
				bet: bet,
				sportsbookWalletTransactionId: sportsbookWalletTransactionId,
				activityDateTime: activityDateTime,
				currentExchangeRate: currentExchangeRate,
				baseCurrencyCode: baseCurrencyCode,
				sourceReferenceId: sourceReferenceId);
	}
}
