using Newtonsoft.Json;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Transaction
{
	public class BetTransactionInfo
	{
		public long CouponId { get; }

		public IEnumerable<WalletTransaction> BetWalletTransactions { get; }

		[JsonConstructor]
		private BetTransactionInfo(long couponId, IEnumerable<WalletTransaction> betWalletTransactions)
		{
			CouponId = couponId;
			BetWalletTransactions = betWalletTransactions;
		}

		public static BetTransactionInfo Create(
			long couponId,
			IEnumerable<WalletTransaction> betWalletTransactions) =>
			new BetTransactionInfo(couponId: couponId, betWalletTransactions: betWalletTransactions);
	}
}