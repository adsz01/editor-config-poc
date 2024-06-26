using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class CreateCustomerRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public RegistrationDetails RegistrationDetails { get; }
		public string PartnerCustomerId { get; }
		public string CurrencyCode { get; }
		public string LanguageCode { get; }
		public AccountStatus AccountStatus { get; }
		public string PartnerClassification { get; }
		public PersonalInformation PersonalInformation { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public CreateCustomerPreferences Preferences { get; }
		public AccountType AccountType { get; }
		public string ExternalEntityId { get; }

		[JsonConstructor]
		private CreateCustomerRequest(ICorrelationRequest correlationRequest, string brandId, RegistrationDetails registrationDetails, string partnerCustomerId, string currencyCode, string languageCode, AccountStatus accountStatus, string partnerClassification, PersonalInformation personalInformation, IDictionary<string, string> additionalData, CreateCustomerPreferences preferences, string externalEntityId, AccountType accountType = AccountType.Real)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			RegistrationDetails = registrationDetails;
			PartnerCustomerId = partnerCustomerId;
			CurrencyCode = currencyCode;
			LanguageCode = languageCode;
			AccountStatus = accountStatus;
			PartnerClassification = partnerClassification;
			PersonalInformation = personalInformation;
			AdditionalData = additionalData;
			Preferences = preferences;
			AccountType = (accountType == default) ? AccountType.Real : accountType;
			ExternalEntityId = externalEntityId;
		}

		public static CreateCustomerRequest Create(ICorrelationRequest correlationRequest, string brandId, RegistrationDetails registrationDetails, string partnerCustomerId, string currencyCode, string languageCode, AccountStatus accountStatus, string partnerClassification, PersonalInformation personalInformation, IDictionary<string, string> additionalData, CreateCustomerPreferences preferences, string externalEntityId, AccountType accountType = AccountType.Real)
		{
			return new CreateCustomerRequest(correlationRequest, brandId, registrationDetails, partnerCustomerId, currencyCode, languageCode, accountStatus, partnerClassification, personalInformation, additionalData, preferences, externalEntityId, accountType);
		}
	}
}
