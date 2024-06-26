using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class DeleteCustomerNoteResponse : ICustomerResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public CustomerResponseCode ResponseCode { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private DeleteCustomerNoteResponse(ICorrelationResponse correlationResponse, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}

		public static DeleteCustomerNoteResponse Create(ICorrelationResponse correlationResponse,
			CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			return new DeleteCustomerNoteResponse(correlationResponse, responseCode, responseNotes);
		}
	}
}
