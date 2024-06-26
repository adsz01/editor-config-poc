using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class CreateCustomerResponse : ICustomerResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public string PartnerCustomerId { get; }
		public string SportsbookCustomerId { get; }
		public CustomerResponseCode ResponseCode { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private CreateCustomerResponse(ICorrelationResponse correlationResponse, string partnerCustomerId, string sportsbookCustomerId, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			PartnerCustomerId = partnerCustomerId;
			SportsbookCustomerId = sportsbookCustomerId;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}

		public static CreateCustomerResponse Create(ICorrelationResponse correlationResponse, string partnerCustomerId, string sportsbookCustomerId, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			return new CreateCustomerResponse(correlationResponse, partnerCustomerId, sportsbookCustomerId, responseCode, responseNotes);
		}

	}
}
