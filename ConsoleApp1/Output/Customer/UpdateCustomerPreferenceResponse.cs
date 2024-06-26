using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class UpdateCustomerPreferenceResponse : ICustomerResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public CustomerResponseCode ResponseCode { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private UpdateCustomerPreferenceResponse(ICorrelationResponse correlationResponse, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}

		public static UpdateCustomerPreferenceResponse Create(ICorrelationResponse correlationResponse, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			return new UpdateCustomerPreferenceResponse(correlationResponse, responseCode, responseNotes);
		}
	}
}
