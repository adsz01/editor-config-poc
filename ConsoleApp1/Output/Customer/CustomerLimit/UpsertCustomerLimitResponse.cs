using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;


namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class UpsertCustomerLimitResponse : ICustomerResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }

		public CustomerResponseCode ResponseCode { get; }

		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private UpsertCustomerLimitResponse(ICorrelationResponse correlationResponse, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}

		public static UpsertCustomerLimitResponse Create(ICorrelationResponse correlationResponse,
			CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			return new UpsertCustomerLimitResponse(correlationResponse, responseCode, responseNotes);
		}
	}

}
