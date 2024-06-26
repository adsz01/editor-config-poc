using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class GetCustomerIdsMappingResponse : ICustomerResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public CustomerResponseCode ResponseCode { get; }
		public IEnumerable<string> ResponseNotes { get; }
		public IEnumerable<CustomerMapping> SuccessfulMappings { get; }
		public IEnumerable<FailedMapping> FailedMappings { get; }
		public string BrandId { get; }
		public string PartnerId { get; }

		[JsonConstructor]
		private GetCustomerIdsMappingResponse(ICorrelationResponse correlationResponse,
			CustomerResponseCode responseCode,
			IEnumerable<string> responseNotes,
			IEnumerable<CustomerMapping> successfulMappings,
			IEnumerable<FailedMapping> failedMappings,
			string brandId,
			string partnerId)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
			SuccessfulMappings = successfulMappings;
			FailedMappings = failedMappings;
			BrandId = brandId;
			PartnerId = partnerId;
		}

		public static GetCustomerIdsMappingResponse Create(ICorrelationResponse correlationResponse,
			CustomerResponseCode responseCode,
			IEnumerable<string> responseNotes,
			IEnumerable<CustomerMapping> successfulMappings,
			IEnumerable<FailedMapping> failedMappings,
			string brandId,
			string partnerId)
		{
			return new GetCustomerIdsMappingResponse(correlationResponse, responseCode, responseNotes, successfulMappings, failedMappings, brandId, partnerId);
		}
	}
}
