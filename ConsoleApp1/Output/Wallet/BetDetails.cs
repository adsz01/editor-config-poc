using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common.Wallet;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Wallet
{
	public class BetDetails
	{
		public string CouponId { get; }
		public string BetId { get; }
		public string CurrencyCode { get; }
		public decimal Amount { get; }
		public MoneyType MoneyType { get; }
		public IEnumerable<Fee> Fees { get; }

		[JsonConstructor]
		private BetDetails(string couponId, string betId, string currencyCode, decimal amount, MoneyType moneyType, IEnumerable<Fee> fees)
		{
			CouponId = couponId;
			BetId = betId;
			CurrencyCode = currencyCode;
			Amount = amount;
			MoneyType = moneyType;
			Fees = fees;
		}

		public static BetDetails Create(string couponId, string betId, string currencyCode, decimal amount, MoneyType moneyType, IEnumerable<Fee> fees)
		{
			return new BetDetails(
				couponId: couponId,
				betId: betId,
				currencyCode: currencyCode,
				amount: amount,
				moneyType: moneyType,
				fees: fees);
		}
	}
}