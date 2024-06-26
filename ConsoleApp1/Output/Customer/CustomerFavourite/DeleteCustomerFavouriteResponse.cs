using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace SB.Customer.Management.Contracts.Output.Customer.CustomerFavourite
{
	public class DeleteCustomerFavouriteResponse : ICustomerResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }

		public CustomerResponseCode ResponseCode { get; }

		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private DeleteCustomerFavouriteResponse(ICorrelationResponse correlationResponse, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}

		public static DeleteCustomerFavouriteResponse Create(ICorrelationResponse correlationResponse, CustomerResponseCode responseCode, IEnumerable<string> responseNotes = null)
		{
			return new DeleteCustomerFavouriteResponse(correlationResponse, responseCode, responseNotes ?? Enumerable.Empty<string>());
		}
	}
}
