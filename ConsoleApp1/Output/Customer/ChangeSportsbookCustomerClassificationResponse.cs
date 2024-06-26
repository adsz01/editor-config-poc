using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class ChangeSportsbookCustomerClassificationResponse : ICustomerResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public CustomerResponseCode ResponseCode { get; }
		public Common.GetCustomer Customer { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private ChangeSportsbookCustomerClassificationResponse(
			ICorrelationResponse correlationResponse,
			CustomerResponseCode responseCode,
			Common.GetCustomer customer,
			IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			Customer = customer;
			ResponseNotes = responseNotes;
		}

		public static ChangeSportsbookCustomerClassificationResponse Create(
			ICorrelationResponse correlationResponse,
			CustomerResponseCode responseCode,
			Common.GetCustomer customer,
			IEnumerable<string> responseNotes)
			=> new ChangeSportsbookCustomerClassificationResponse(
				correlationResponse,
				responseCode,
				customer,
				responseNotes);
	}
}