using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class UpdateCustomerDetailsResponse : ICustomerResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public string SportsbookCustomerId { get; }
		public CustomerResponseCode ResponseCode { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private UpdateCustomerDetailsResponse(ICorrelationResponse correlationResponse, string sportsbookCustomerId, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			SportsbookCustomerId = sportsbookCustomerId;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}

		public static UpdateCustomerDetailsResponse Create(ICorrelationResponse correlationResponse, string sportsbookCustomerId, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			return new UpdateCustomerDetailsResponse(correlationResponse, sportsbookCustomerId, responseCode, responseNotes);
		}
	}
}
