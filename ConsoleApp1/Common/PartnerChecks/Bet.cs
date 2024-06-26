using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common.Wallet;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Common.PartnerChecks
{
	public class Bet
	{
		public string CouponId { get; }
		public string BetId { get; }
		public decimal OriginalStake { get; }
		public decimal RemainingStake { get; }
		public string CurrencyCode { get; }
		public BonusType BonusFlag { get; }
		public IEnumerable<BetSelection> BetSelections { get; }

		[JsonConstructor]
		private Bet(string couponId, string betId, BonusType bonusFlag, IEnumerable<BetSelection> betSelections, decimal originalStake,
			decimal remainingStake, string currencyCode)
		{
			CouponId = couponId;
			BetId = betId;
			BonusFlag = bonusFlag;
			BetSelections = betSelections;
			OriginalStake = originalStake;
			RemainingStake = remainingStake;
			CurrencyCode = currencyCode;
		}

		public static Bet Create(string couponId, string betId, BonusType bonusFlag, IEnumerable<BetSelection> betSelections, decimal originalStake,
			decimal remainingStake, string currencyCode) =>
			new Bet(couponId: couponId, betId: betId, bonusFlag: bonusFlag, betSelections: betSelections, originalStake: originalStake,
				remainingStake: remainingStake, currencyCode: currencyCode);
	}
}