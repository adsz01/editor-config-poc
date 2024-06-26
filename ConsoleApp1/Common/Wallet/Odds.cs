using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Common.Wallet
{
	public class Odds
	{
		public decimal Value { get; }
		public decimal? BoostedValue { get; }

		[JsonConstructor]
		private Odds(decimal value, decimal? boostedValue)
		{
			Value = value;
			BoostedValue = boostedValue;
		}

		public static Odds Create(decimal value, decimal? boostedValue)
		{
			return new Odds(
				value: value,
				boostedValue: boostedValue);
		}
	}
}
