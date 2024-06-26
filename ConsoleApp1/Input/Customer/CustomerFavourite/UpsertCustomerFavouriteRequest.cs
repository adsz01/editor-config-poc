using System.Collections.Generic;
using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;

namespace SB.Customer.Management.Contracts.Input.Customer.CustomerFavourite
{
	public class UpsertCustomerFavouriteRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }

		public string SportsbookCustomerId { get; }

		public IEnumerable<Common.CustomerFavourite> CustomerFavourites { get; }

		public string RequestedBy { get; }

		[JsonConstructor]
		private UpsertCustomerFavouriteRequest(ICorrelationRequest correlationRequest,string sportsbookCustomerId, IEnumerable<Common.CustomerFavourite> customerFavourites, string requestedBy)
		{
			CorrelationRequest = correlationRequest;
			SportsbookCustomerId = sportsbookCustomerId;
			CustomerFavourites = customerFavourites;
			RequestedBy = requestedBy;
		}

		public static UpsertCustomerFavouriteRequest Create(ICorrelationRequest correlationRequest, string sportsbookCustomerId, IEnumerable<Common.CustomerFavourite> customerFavourites, string requestedBy)
		{
			return new UpsertCustomerFavouriteRequest(correlationRequest, sportsbookCustomerId, customerFavourites, requestedBy);
		}
	}
}
