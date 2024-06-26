using Newtonsoft.Json;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Common
{
	public class FailedCustomer
	{
		public string SportsbookCustomerId { get; }
		public IEnumerable<ErrorDetails> ErrorDetails { get; }

		[JsonConstructor]
		private FailedCustomer(string sportsbookCustomerId, IEnumerable<ErrorDetails> errorDetails)
		{
			SportsbookCustomerId = sportsbookCustomerId;
			ErrorDetails = errorDetails;
		}

		public static FailedCustomer Create(string sportsbookCustomerId, IEnumerable<ErrorDetails> errorDetails)
		{
			return new FailedCustomer(sportsbookCustomerId, errorDetails);
		}
	}
}
