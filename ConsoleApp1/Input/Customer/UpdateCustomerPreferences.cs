using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class UpdateCustomerPreferences
	{
		public BetSlipOddChangeBehaviour? BetSlipOddChangeBehaviour { get; }

		public OddsFormatType? OddFormatType { get; }

		public OriginOfValue? Origin { get; }

		[JsonConstructor]
		private UpdateCustomerPreferences(BetSlipOddChangeBehaviour? betSlipOddChangeBehaviour, OddsFormatType? oddFormatType, OriginOfValue? origin)
		{
			BetSlipOddChangeBehaviour = betSlipOddChangeBehaviour;
			OddFormatType = oddFormatType;
			Origin = origin;
		}

		public static UpdateCustomerPreferences Create(BetSlipOddChangeBehaviour? betSlipOddChangeBehaviour, OddsFormatType? oddFormatType, OriginOfValue? origin)
		{
			return new UpdateCustomerPreferences(betSlipOddChangeBehaviour, oddFormatType, origin);
		}
	}
}