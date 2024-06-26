using Newtonsoft.Json;
using System;

namespace SB.Customer.Management.Contracts.Output.Wallet.Void
{
	public class VoidedActivityDetails
	{
		public string CouponId { get; }
		public string BetId { get; }
		public DateTime VoidingDateTime { get; }

		[JsonConstructor]
		private VoidedActivityDetails(string couponId, string betId, DateTime voidingDateTime)
		{
			CouponId = couponId;
			BetId = betId;
			VoidingDateTime = voidingDateTime;
		}

		public static VoidedActivityDetails Create(string couponId, string betId, DateTime voidingDateTime)
		{
			return new VoidedActivityDetails(
				couponId: couponId,
				betId: betId,
				voidingDateTime: voidingDateTime);
		}
	}
}