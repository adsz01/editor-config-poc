using Newtonsoft.Json;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Common
{
	public class CustomerLimit
	{
		public string SportsbookCustomerId { get; }

		public IEnumerable<LimitConfiguration> LimitConfigurations { get; }

		[JsonConstructor]
		protected CustomerLimit(string sportsbookCustomerId, IEnumerable<LimitConfiguration> limitConfigurations)
		{
			SportsbookCustomerId = sportsbookCustomerId;
			LimitConfigurations = limitConfigurations;
		}

		public static CustomerLimit Create(string sportsbookCustomerId, IEnumerable<LimitConfiguration> limitConfigurations)
		{
			return new CustomerLimit(sportsbookCustomerId, limitConfigurations);
		}
	}
}
