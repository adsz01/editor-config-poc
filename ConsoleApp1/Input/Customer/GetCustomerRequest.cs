using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class GetCustomerRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public IDictionary<SearchCriteria, IEnumerable<string>> SearchFilters { get; }
		public HashSet<CustomerResponseDetail> CustomerResponseDetails { get; }
		public int PageSize { get; }
		public int Page { get; }

		[JsonConstructor]
		private GetCustomerRequest(ICorrelationRequest correlationRequest, string brandId, IDictionary<SearchCriteria, IEnumerable<string>> searchFilters, HashSet<CustomerResponseDetail> customerResponseDetails, int pageSize, int page)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			SearchFilters = searchFilters;
			CustomerResponseDetails = customerResponseDetails;
			PageSize = pageSize;
			Page = page;
		}

		public static GetCustomerRequest Create(ICorrelationRequest correlationRequest, string brandId, IDictionary<SearchCriteria, IEnumerable<string>> searchFilters, HashSet<CustomerResponseDetail> customerResponseDetails, int pageSize, int page)
		{
			return new GetCustomerRequest(correlationRequest, brandId, searchFilters, customerResponseDetails, pageSize, page);
		}
	}
}
