using Newtonsoft.Json;
using System;

namespace SB.Customer.Management.Contracts.Output.Wallet.Legacy
{
	public class B2CWalletTransaction
	{
		public string WalletTransactionID { get; }
		public string TransactionRef { get; }
		public long? BetID { get; }
		public long CouponID { get; }
		public DateTime CreatedDate { get; }
		public string GameID { get; }
		public decimal Amount { get; }
		public string CurrencyCode { get; }
		public string WalletRollbackID { get; }
		public bool IsFinal { get; }
		public int WalletID { get; }
		public string TaxWalletTransactionID { get; }
		public string TaxWalletRollbackID { get; }
		public decimal? TaxAmount { get; }
		public bool? IsBonusPayout { get; }
		public bool? IsCashout { get; }

		[JsonConstructor]
		private B2CWalletTransaction(string walletTransactionId, string transactionRef, long? betId, long couponId, DateTime createdDate, string gameId, decimal amount, string currencyCode, string walletRollbackId, bool isFinal, int walletId, string taxWalletTransactionId, string taxWalletRollbackId, decimal? taxAmount, bool? isBonusPayout, bool? isCashout)
		{
			WalletTransactionID = walletTransactionId;
			TransactionRef = transactionRef;
			BetID = betId;
			CouponID = couponId;
			CreatedDate = createdDate;
			GameID = gameId;
			Amount = amount;
			CurrencyCode = currencyCode;
			WalletRollbackID = walletRollbackId;
			IsFinal = isFinal;
			WalletID = walletId;
			TaxWalletTransactionID = taxWalletTransactionId;
			TaxWalletRollbackID = taxWalletRollbackId;
			TaxAmount = taxAmount;
			IsBonusPayout = isBonusPayout;
			IsCashout = isCashout;
		}

		public static B2CWalletTransaction Create(string walletTransactionId, string transactionRef, long? betId,
			long couponId, DateTime createdDate, string gameId, decimal amount, string currencyCode,
			string walletRollbackId, bool isFinal, int walletId,
			string taxWalletTransactionId, string taxWalletRollbackId, decimal? taxAmount, bool? isBonusPayout,
			bool? isCashout)
		{
			return new B2CWalletTransaction(
				walletTransactionId,
				transactionRef,
				betId,
				couponId,
				createdDate,
				gameId,
				amount,
				currencyCode,
				walletRollbackId,
				isFinal,
				walletId,
				taxWalletTransactionId,
				taxWalletRollbackId,
				taxAmount,
				isBonusPayout,
				isCashout);
		}
	}
}
