using System;
using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace SB.Customer.Management.Contracts.Output.Customer.CustomerFavourite
{
	public class UpsertCustomerFavouriteResponse : ICustomerResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }

		public IEnumerable<Guid> FavouriteIds { get; set; }

		public CustomerResponseCode ResponseCode { get; }

		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		private UpsertCustomerFavouriteResponse(ICorrelationResponse correlationResponse, IEnumerable<Guid> favouriteIds, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CorrelationResponse = correlationResponse;
			FavouriteIds = favouriteIds;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
		}

		public static UpsertCustomerFavouriteResponse Create(ICorrelationResponse correlationResponse, IEnumerable<Guid> favouriteIds, CustomerResponseCode responseCode, IEnumerable<string> responseNotes = null)
		{
			return new UpsertCustomerFavouriteResponse(correlationResponse, favouriteIds, responseCode, responseNotes ?? Enumerable.Empty<string>());
		}
	}
}
