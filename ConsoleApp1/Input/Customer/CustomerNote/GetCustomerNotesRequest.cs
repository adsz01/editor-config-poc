using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class GetCustomerNotesRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string SportsbookCustomerId { get; }
		public NoteType NoteType { get; }

		[JsonConstructor]
		private GetCustomerNotesRequest(ICorrelationRequest correlationRequest, string sportsbookCustomerId, NoteType noteType)
		{
			CorrelationRequest = correlationRequest;
			SportsbookCustomerId = sportsbookCustomerId;
			NoteType = noteType;
		}

		public static GetCustomerNotesRequest Create(ICorrelationRequest correlationRequest, string sportsbookCustomerId, NoteType noteType)
		{
			return new GetCustomerNotesRequest(correlationRequest, sportsbookCustomerId, noteType);
		}
	}
}
