using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class CustomerIdMappingQuery
	{
		public string CustomerId { get; }
		public CustomerMappingQueryType MappingQueryType { get; }
		public string ExternalEntityId { get; }

		[JsonConstructor]
		private CustomerIdMappingQuery(string customerId, CustomerMappingQueryType mappingQueryType, string externalEntityId)
		{
			CustomerId = customerId;
			MappingQueryType = mappingQueryType;
			ExternalEntityId = externalEntityId;
		}

		public static CustomerIdMappingQuery Create(string customerId, CustomerMappingQueryType mappingQueryType, string externalEntityId)
		{
			return new CustomerIdMappingQuery(customerId, mappingQueryType, externalEntityId);
		}
	}
}
