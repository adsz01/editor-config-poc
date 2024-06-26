using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class ChangePartnerCustomerClassificationResponse : ICustomerResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public CustomerResponseCode ResponseCode { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private ChangePartnerCustomerClassificationResponse(ICorrelationResponse correlationResponse, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}
		public static ChangePartnerCustomerClassificationResponse Create(ICorrelationResponse correlationResponse, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
			=> new ChangePartnerCustomerClassificationResponse(correlationResponse, responseCode, responseNotes);
	}
}
