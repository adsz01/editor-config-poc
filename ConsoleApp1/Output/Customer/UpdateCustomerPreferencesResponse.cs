using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class UpdateCustomerPreferencesResponse : ICustomerResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public string SportsbookCustomerId { get; }
		public CustomerResponseCode ResponseCode { get; }
		public IEnumerable<string> ResponseNotes { get; }
		
		public UpdateCustomerPreferencesResponse(ICorrelationResponse correlationResponse, string sportsbookCustomerId, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			SportsbookCustomerId = sportsbookCustomerId;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}
	}
}
