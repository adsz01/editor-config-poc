using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class DeleteCustomerAdditionalInfoRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public string SportsbookCustomerId { get; }
		public IEnumerable<string> AdditionalInfoKeys { get; }

		[JsonConstructor]
		private DeleteCustomerAdditionalInfoRequest(ICorrelationRequest correlationRequest, string brandId, string sportsbookCustomerId, IEnumerable<string> additionalInfoKeys)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			SportsbookCustomerId = sportsbookCustomerId;
			AdditionalInfoKeys = additionalInfoKeys;
		}

		public static DeleteCustomerAdditionalInfoRequest Create(ICorrelationRequest correlationRequest, string brandId, string sportsbookCustomerId, IEnumerable<string> additionalInfoKeys)
		{
			return new DeleteCustomerAdditionalInfoRequest(correlationRequest, brandId, sportsbookCustomerId, additionalInfoKeys);
		}
	}
}