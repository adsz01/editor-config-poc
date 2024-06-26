using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class GetCustomerLimitsAndClassificationRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }

		public IEnumerable<CustomerFilter> CustomerFilters { get; }

		[JsonConstructor]
		private GetCustomerLimitsAndClassificationRequest(ICorrelationRequest correlationRequest, IEnumerable<CustomerFilter> customerFilters)
		{
			CorrelationRequest = correlationRequest;
			CustomerFilters = customerFilters;
		}

		public static GetCustomerLimitsAndClassificationRequest Create(ICorrelationRequest correlationRequest, IEnumerable<CustomerFilter> sportsbookCustomerIdAndBrandIdPairs)
		{
			return new GetCustomerLimitsAndClassificationRequest(correlationRequest, sportsbookCustomerIdAndBrandIdPairs);
		}
	}
}
