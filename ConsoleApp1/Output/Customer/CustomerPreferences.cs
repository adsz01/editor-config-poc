using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class CustomerPreferences
	{
		public AcceptOddChanges AcceptOddChanges { get; }
		public OddsFormat OddsFormat { get; }

		[JsonConstructor]
		private CustomerPreferences(AcceptOddChanges acceptOddChanges, OddsFormat oddsFormat)
		{
			AcceptOddChanges = acceptOddChanges;
			OddsFormat = oddsFormat;
		}

		public static CustomerPreferences Create(AcceptOddChanges acceptOddChanges, OddsFormat oddsFormat)
		{
			return new CustomerPreferences(acceptOddChanges, oddsFormat);
		}
	}
}