using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class CustomerNote
	{
		public long? NoteId { get; }
		public string SportsbookCustomerId { get; }
		public Guid? CustomerId { get; }
		public string Note { get; }
		public Dictionary<string, object> NoteMetadata { get; }
		public DateTime NoteCreated { get; }
		public string NoteCreator { get; }
		public NoteFlag NoteFlag { get; }

		[JsonConstructor]
		private CustomerNote(long? noteId, string sportsbookCustomerId, Guid? customerId, string note, Dictionary<string, object> noteMetadata, DateTime noteCreated, string noteCreator, NoteFlag noteFlag)
		{
			SportsbookCustomerId = sportsbookCustomerId;
			CustomerId = customerId;
			Note = note;
			NoteMetadata = noteMetadata;
			NoteCreated = noteCreated;
			NoteCreator = noteCreator;
			NoteFlag = noteFlag;
			NoteId = noteId;
		}

		public static CustomerNote Create(long? noteId, string sportsbookCustomerId, Guid? customerId, string note, Dictionary<string, object> noteMetadata, DateTime noteCreated, string noteCreator, NoteFlag noteFlag)
		{
			return new CustomerNote(noteId, sportsbookCustomerId, customerId, note, noteMetadata, noteCreated, noteCreator, noteFlag);
		}
	}
}
