using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class CreateCustomerNoteResponse : ICustomerResponse
	{
		public long NoteId { get; }
		public ICorrelationResponse CorrelationResponse { get; }
		public CustomerResponseCode ResponseCode { get; }
		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private CreateCustomerNoteResponse(ICorrelationResponse correlationResponse, long noteId, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			NoteId = noteId;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}

		public static CreateCustomerNoteResponse Create(ICorrelationResponse correlationResponse, long noteId, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			return new CreateCustomerNoteResponse(correlationResponse, noteId, responseCode, responseNotes);
		}
	}
}
