using SB.Community.Correlation.Interfaces;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class UpdateCustomerPreferencesRequest : ICommunityCorrelationRequest
	{
		
		public ICorrelationRequest CorrelationRequest { get; }

		public string BrandId { get; }

		public string SportsbookCustomerId { get; }
		public UpdateCustomerPreferences CustomerPreferences { get; }

		public UpdateCustomerPreferencesRequest(ICorrelationRequest correlationRequest, string brandId, string sportsbookCustomerId, UpdateCustomerPreferences customerPreferences)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			SportsbookCustomerId = sportsbookCustomerId;
			CustomerPreferences = customerPreferences;
		}
	}
}
