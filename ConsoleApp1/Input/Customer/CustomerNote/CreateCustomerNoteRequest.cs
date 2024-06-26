using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class CreateCustomerNoteRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string SportsbookCustomerId { get; }
		public Guid? CustomerId { get; }
		public string Note { get; }
		public Dictionary<string, object> NoteMetadata { get; }
		public NoteType NoteType { get; }
		public string NoteCreator { get; }
		public NoteFlag NoteFlag { get; }

		[JsonConstructor]
		private CreateCustomerNoteRequest(ICorrelationRequest correlationRequest, string sportsbookCustomerId, Guid? customerId, string note, Dictionary<string, object> noteMetadata, string noteCreator, NoteFlag noteFlag, NoteType noteType)
		{
			CorrelationRequest = correlationRequest;
			SportsbookCustomerId = sportsbookCustomerId;
			CustomerId = customerId;
			Note = note;
			NoteMetadata = noteMetadata;
			NoteCreator = noteCreator;
			NoteFlag = noteFlag;
			NoteType = noteType;
		}

		public static CreateCustomerNoteRequest Create(ICorrelationRequest correlationRequest, string sportsbookCustomerId, Guid? customerId, string note, Dictionary<string, object> noteMetadata, string noteCreator, NoteFlag noteFlag, NoteType noteType)
		{
			return new CreateCustomerNoteRequest(correlationRequest, sportsbookCustomerId, customerId, note, noteMetadata, noteCreator, noteFlag, noteType);
		}
	}
}
