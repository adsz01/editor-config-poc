using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class UpdateCustomerPreferenceRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public string UserContextId { get; }
		public string PreferenceKey { get; }
		public string PreferenceValue { get; }
		public string SportsbookCustomerId { get; }

		[JsonConstructor]
		private UpdateCustomerPreferenceRequest(ICorrelationRequest correlationRequest, string brandId, string userContextId, string preferenceKey, string preferenceValue, string sportsbookCustomerId)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			UserContextId = userContextId;
			PreferenceKey = preferenceKey;
			PreferenceValue = preferenceValue;
			SportsbookCustomerId = sportsbookCustomerId;
		}

		public static UpdateCustomerPreferenceRequest Create(ICorrelationRequest correlationRequest, string brandId, string userContextId, string preferenceKey, string preferenceValue, string sportsbookCustomerId)
		{
			return new UpdateCustomerPreferenceRequest(correlationRequest, brandId, userContextId, preferenceKey, preferenceValue, sportsbookCustomerId);
		}
	}
}