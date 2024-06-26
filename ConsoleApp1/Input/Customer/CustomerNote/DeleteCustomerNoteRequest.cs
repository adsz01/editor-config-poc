using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;


namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class DeleteCustomerNoteRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public long NoteId { get; }

		[JsonConstructor]
		private DeleteCustomerNoteRequest(ICorrelationRequest correlationRequest, long noteId)
		{
			CorrelationRequest = correlationRequest;
			NoteId = noteId;
		}

		public static DeleteCustomerNoteRequest Create(ICorrelationRequest correlationRequest, long noteId)
		{
			return new DeleteCustomerNoteRequest(correlationRequest, noteId);
		}
	}
}
