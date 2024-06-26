using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Common
{
	public class SuccessfulCustomer
	{
		public string SportsbookCustomerId { get; }

		[JsonConstructor]
		private SuccessfulCustomer(string sportsbookCustomerId)
		{
			SportsbookCustomerId = sportsbookCustomerId;
		}

		public static SuccessfulCustomer Create(string sportsbookCustomerId)
		{
			return new SuccessfulCustomer(sportsbookCustomerId);
		}
	}
}
