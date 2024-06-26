using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class ChangeAccountStatusResponse : ICustomerResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public CustomerResponseCode ResponseCode { get; }
		public Common.GetCustomer Customer { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private ChangeAccountStatusResponse(
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

		public static ChangeAccountStatusResponse Create(
			ICorrelationResponse correlationResponse,
			CustomerResponseCode responseCode,
			Common.GetCustomer customer,
			IEnumerable<string> responseNotes)
			=> new ChangeAccountStatusResponse(
				correlationResponse,
				responseCode,
				customer,
				responseNotes);
	}
}