using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Output.Wallet.Events
{
	public class Bet
	{
		public string CouponId { get; }
		public string BetId { get; }

		[JsonConstructor]
		private Bet(string couponId, string betId)
		{
			CouponId = couponId;
			BetId = betId;
		}

		public static Bet Create(string couponId, string betId) =>
			new Bet(couponId, betId);
	}
}
