using System.Collections.Generic;
using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;

namespace SB.Customer.Management.Contracts.Input.Customer.CustomerFavourite
{
	public class DeleteCustomerFavouriteRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }

		public string SportsbookCustomerId { get; }

		public IEnumerable<string> FavouriteIds { get; }

		public string RequestedBy { get; }

		[JsonConstructor]
		private DeleteCustomerFavouriteRequest(ICorrelationRequest correlationRequest, string sportsbookCustomerId, IEnumerable<string> favouriteIds, string requestedBy)
		{
			CorrelationRequest = correlationRequest;
			SportsbookCustomerId = sportsbookCustomerId;
			FavouriteIds = favouriteIds;
			RequestedBy = requestedBy;
		}

		public static DeleteCustomerFavouriteRequest Create(ICorrelationRequest correlationRequest, string sportsbookCustomerId, IEnumerable<string> favouriteIds, string requestedBy)
		{
			return new DeleteCustomerFavouriteRequest(correlationRequest, sportsbookCustomerId, favouriteIds, requestedBy);
		}
	}
}
