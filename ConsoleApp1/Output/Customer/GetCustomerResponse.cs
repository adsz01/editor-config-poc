using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class GetCustomerResponse : ICustomerResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public CustomerResponseCode ResponseCode { get; }
		public IEnumerable<Contracts.Common.GetCustomer> Customers { get; }
		public IEnumerable<string> ResponseNotes { get; }
		public int TotalResult { get; }
		public int TotalPages { get; }
		public int Page { get; }

		[JsonConstructor]
		private GetCustomerResponse(ICorrelationResponse correlationResponse, CustomerResponseCode responseCode, IEnumerable<Contracts.Common.GetCustomer> customers, IEnumerable<string> responseNotes, int totalResult, int totalPages, int page)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			Customers = customers;
			ResponseNotes = responseNotes;
			TotalResult = totalResult;
			TotalPages = totalPages;
			Page = page;
		}

		public static GetCustomerResponse Create(ICorrelationResponse correlationResponse, CustomerResponseCode responseCode, IEnumerable<Contracts.Common.GetCustomer> customers, IEnumerable<string> responseNotes, int totalResult, int totalPages, int page)
		{
			return new GetCustomerResponse(correlationResponse, responseCode, customers, responseNotes, totalResult, totalPages, page);
		}
	}
}