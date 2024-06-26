using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Common
{
	public class AcceptOddChanges
	{
		public BetSlipOddChangeBehaviour BetSlipOddChangeBehaviour { get; }
		public OriginOfValue OriginOfValue { get; }

		[JsonConstructor]
		private AcceptOddChanges(BetSlipOddChangeBehaviour betSlipOddChangeBehaviour, OriginOfValue originOfValue)
		{
			BetSlipOddChangeBehaviour = betSlipOddChangeBehaviour;
			OriginOfValue = originOfValue;
		}

		public static AcceptOddChanges Create(BetSlipOddChangeBehaviour betSlipOddChangeBehaviour, OriginOfValue originOfValue)
		{
			return new AcceptOddChanges(betSlipOddChangeBehaviour, originOfValue);
		}
	}
}