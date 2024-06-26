using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class UpsertCustomerLimitRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }

		public CustomerLimit CustomerLimit { get; }

		public string RequestedBy { get; }

		[JsonConstructor]
		private UpsertCustomerLimitRequest(ICorrelationRequest correlationRequest, CustomerLimit customerLimit, string requestedBy)
		{
			CorrelationRequest = correlationRequest;
			CustomerLimit = customerLimit;
			RequestedBy = requestedBy;
		}

		public static UpsertCustomerLimitRequest Create(ICorrelationRequest correlationRequest, CustomerLimit customerLimit, string requestedBy)
		{
			return new UpsertCustomerLimitRequest(correlationRequest, customerLimit, requestedBy);
		}
	}
}
