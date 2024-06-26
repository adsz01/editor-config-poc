using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common;

namespace SB.Customer.Management.Contracts.Output
{
	public class FailedMapping
	{
		public string CustomerId { get; }
		public string ExternalEntityId { get; }
		public MappingFailedReasonCode FailedReasonCode { get; }
		public CustomerMappingQueryType MappingQueryType { get; }
		public string FailedReason { get; }

		[JsonConstructor]
		private FailedMapping(string customerId, string externalEntityId, MappingFailedReasonCode failedReasonCode, string failedReason, CustomerMappingQueryType mappingQueryType)
		{
			CustomerId = customerId;
			ExternalEntityId = externalEntityId;
			FailedReasonCode = failedReasonCode;
			FailedReason = failedReason;
			MappingQueryType = mappingQueryType;
		}

		public static FailedMapping Create(string customerId, string externalEntityId, MappingFailedReasonCode failedReasonCode, string failedReason, CustomerMappingQueryType mappingQueryType)
		{
			return new FailedMapping(customerId, externalEntityId, failedReasonCode, failedReason, mappingQueryType);
		}

	}
}
