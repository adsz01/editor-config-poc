using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class GetCustomerNotesResponse : ICustomerResponse
	{
		public IList<CustomerNote> CustomerNotes { get; }
		public ICorrelationResponse CorrelationResponse { get; }
		public CustomerResponseCode ResponseCode { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private GetCustomerNotesResponse(ICorrelationResponse correlationResponse, IList<CustomerNote> customerNotes, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			CustomerNotes = customerNotes;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}

		public static GetCustomerNotesResponse Create(ICorrelationResponse correlationResponse, IList<CustomerNote> customerNotes, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			return new GetCustomerNotesResponse(correlationResponse, customerNotes, responseCode, responseNotes);
		}
	}
}
