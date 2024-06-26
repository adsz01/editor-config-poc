using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class UpdateCustomerDetailsRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public string SportsbookCustomerId { get; }
		public string PartnerCustomerClassification { get; }
		public string LanguageCode { get; }
		public UpdatePersonalInformation PersonalInformation { get; }
		public UpdateCustomerPreferences CustomerPreferences { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public AccountType? AccountType { get; }

		[JsonConstructor]
		private UpdateCustomerDetailsRequest(ICorrelationRequest correlationRequest, string brandId,
			string sportsbookCustomerId, string partnerCustomerClassification, string languageCode,
			UpdatePersonalInformation personalInformation, UpdateCustomerPreferences customerPreferences,
			IDictionary<string, string> additionalData, AccountType? accountType)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			SportsbookCustomerId = sportsbookCustomerId;
			PartnerCustomerClassification = partnerCustomerClassification;
			CustomerPreferences = customerPreferences;
			PersonalInformation = personalInformation;
			AdditionalData = additionalData;
			LanguageCode = languageCode;
			AccountType = accountType;
		}

		public static UpdateCustomerDetailsRequest Create(ICorrelationRequest correlationRequest, string brandId,
			string sportsbookCustomerId, string partnerCustomerClassification, string languageCode,
			UpdatePersonalInformation personalInformation, UpdateCustomerPreferences customerPreferences,
			IDictionary<string, string> additionalData, AccountType? accountType)
		{
			return new UpdateCustomerDetailsRequest(correlationRequest, brandId, sportsbookCustomerId, partnerCustomerClassification,
				languageCode, personalInformation, customerPreferences, additionalData, accountType);
		}
	}
}
