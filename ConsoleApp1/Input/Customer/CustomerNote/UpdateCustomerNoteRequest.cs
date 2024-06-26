using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common;


namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class UpdateCustomerNoteRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public long NoteId { get; }
		public NoteFlag NoteFlag { get; }

		[JsonConstructor]
		private UpdateCustomerNoteRequest(ICorrelationRequest correlationRequest, long noteId, NoteFlag noteFlag)
		{
			CorrelationRequest = correlationRequest;
			NoteId = noteId;
			NoteFlag = noteFlag;
		}

		public static UpdateCustomerNoteRequest Create(ICorrelationRequest correlationRequest, long noteId, NoteFlag noteFlag)
		{
			return new UpdateCustomerNoteRequest(correlationRequest, noteId, noteFlag);
		}
	}
}
