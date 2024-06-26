using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Transaction
{
	public class GetTransactionsRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public IEnumerable<int> MerchantIds { get; }
		public SearchCriteria SearchCriteria { get; }
		public IEnumerable<long> SearchFilters { get; }

		[JsonConstructor]
		private GetTransactionsRequest(ICorrelationRequest correlationRequest, IEnumerable<int> merchantIds, SearchCriteria searchCriteria, IEnumerable<long> searchFilters)
		{
			CorrelationRequest = correlationRequest;
			MerchantIds = merchantIds;
			SearchCriteria = searchCriteria;
			SearchFilters = searchFilters;
		}

		public static GetTransactionsRequest Create(ICorrelationRequest correlationRequest, IEnumerable<int> merchantIds, SearchCriteria searchCriteria, IEnumerable<long> searchFilters)
		{
			return new GetTransactionsRequest(correlationRequest, merchantIds, searchCriteria, searchFilters);
		}
	}
}
