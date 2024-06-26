using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class GetCustomerIdsMappingRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public IEnumerable<CustomerIdMappingQuery> Customers { get; }
		public string BrandId { get; }
		public CustomerDataSource? CustomerDataSource { get; }

		[JsonConstructor]
		private GetCustomerIdsMappingRequest(ICorrelationRequest correlationRequest, IEnumerable<CustomerIdMappingQuery> customers, string brandId, CustomerDataSource? customerDataSource)
		{
			CorrelationRequest = correlationRequest;
			Customers = customers;
			BrandId = brandId;
			CustomerDataSource = customerDataSource;
		}

		public static GetCustomerIdsMappingRequest Create(ICorrelationRequest correlationRequest, IEnumerable<CustomerIdMappingQuery> customers, string brandId, CustomerDataSource? customerDataSource)
		{
			return new GetCustomerIdsMappingRequest(correlationRequest, customers, brandId, customerDataSource);
		}
	}
}
