using Newtonsoft.Json;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Common
{
	public class CustomerLimitAndClassification : CustomerLimit
	{
		public SportsbookCustomerClassification Classification { get; }

		[JsonConstructor]
		private CustomerLimitAndClassification(string sportsbookCustomerId, SportsbookCustomerClassification classification, IEnumerable<LimitConfiguration> limitConfigurations)
			: base(sportsbookCustomerId, limitConfigurations)
		{
			Classification = classification;
		}

		public static CustomerLimitAndClassification Create(string sportsbookCustomerId, SportsbookCustomerClassification classification,
			IEnumerable<LimitConfiguration> limitConfigurations)
		{
			return new CustomerLimitAndClassification(sportsbookCustomerId, classification, limitConfigurations);
		}
	}
}
