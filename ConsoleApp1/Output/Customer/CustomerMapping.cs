using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class CustomerMapping
	{
		public string PartnerCustomerId { get; }
		public string SportsbookCustomerId { get; }
		public string ExternalEntityId { get; private set; }

		[JsonConstructor]
		private CustomerMapping(string partnerCustomerId, string sportsbookCustomerId, string externalEntityId)
		{
			PartnerCustomerId = partnerCustomerId;
			SportsbookCustomerId = sportsbookCustomerId;
			ExternalEntityId = externalEntityId;
		}

		public static CustomerMapping Create(string partnerCustomerId, string sportsbookCustomerId, string externalEntityId)
		{
			return new CustomerMapping(partnerCustomerId, sportsbookCustomerId, externalEntityId);
		}
	}
}
