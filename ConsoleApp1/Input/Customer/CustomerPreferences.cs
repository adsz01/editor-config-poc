using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class CustomerPreferences
	{
		public BetSlipOddChangeBehaviour BetSlipOddChangeBehaviour { get; }
		public OddsFormatType OddsFormatType { get; }

		[JsonConstructor]
		private CustomerPreferences(BetSlipOddChangeBehaviour betSlipOddChangeBehaviour, OddsFormatType oddsFormatType)
		{
			BetSlipOddChangeBehaviour = betSlipOddChangeBehaviour;
			OddsFormatType = oddsFormatType;
		}

		public static CustomerPreferences Create(BetSlipOddChangeBehaviour betSlipOddChangeBehaviour, OddsFormatType oddsFormatType)
		{
			return new CustomerPreferences(betSlipOddChangeBehaviour, oddsFormatType);
		}
	}
}