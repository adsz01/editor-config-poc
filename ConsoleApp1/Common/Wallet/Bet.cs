using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Common.Wallet
{
	public class Bet
	{
		public string CouponId { get; }
		public string BetId { get; }
		public BonusType BonusFlag { get; }
		public IEnumerable<BetSelection> BetSelections { get; }
		public Guid? BonusGuid { get; }
		public decimal StakeAmount { get; }
		public Odds CombinedOdds { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public decimal RedeemedStake { get; }
		public decimal RemainingStake { get; }
		public int? BonusVersion { get; }

		[JsonConstructor]
		private Bet(string couponId, string betId, BonusType bonusFlag, IEnumerable<BetSelection> betSelections,
			decimal stakeAmount, Guid? bonusGuid, IDictionary<string, string> additionalData, decimal redeemedStake,
			decimal remainingStake, int? bonusVersion, Odds combinedOdds = null)
		{
			CouponId = couponId;
			BetId = betId;
			BonusFlag = bonusFlag;
			BetSelections = betSelections;
			BonusGuid = bonusGuid;
			StakeAmount = stakeAmount;
			CombinedOdds = combinedOdds;
			AdditionalData = additionalData;
			RedeemedStake = redeemedStake;
			RemainingStake = remainingStake;
			BonusVersion = bonusVersion;
		}

		public static Bet Create(
			string couponId,
			string betId,
			BonusType bonusFlag,
			IEnumerable<BetSelection> betSelections,
			decimal stakeAmount,
			Guid? bonusGuid,
			IDictionary<string, string> additionalData,
			decimal redeemedStake,
			decimal remainingStake,
			int? bonusVersion,
			Odds combinedOdds = null) =>
			new Bet(
				couponId: couponId,
				betId: betId,
				bonusFlag: bonusFlag,
				betSelections: betSelections,
				stakeAmount: stakeAmount,
				bonusGuid: bonusGuid,
				additionalData: additionalData,
				redeemedStake: redeemedStake,
				remainingStake: remainingStake,
				combinedOdds: combinedOdds,
				bonusVersion: bonusVersion);
	}
}