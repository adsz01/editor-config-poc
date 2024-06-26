using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Output.Customer;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Common
{
	public class Customer
	{
		public string SportsbookCustomerId { get; }
		public string PartnerCustomerId { get; }
		public string BrandId { get; }
		public string CurrencyCode { get; }
		public string LanguageCode { get; }
		public AccountStatus AccountStatus { get; }
		public SportsbookCustomerClassification SportsbookCustomerClassification { get; }
		public string PartnerCustomerClassification { get; }
		public RegistrationDetails RegistrationDetails { get; }
		public PersonalInformation PersonalInformation { get; }
		public IEnumerable<Comment> Comments { get; }
		public IEnumerable<AssociatedAccount> AssociatedAccounts { get; }
		public IDictionary<string, string> PartnerCustomerAdditionalData { get; }
		public CustomerPreferences CustomerPreferences { get; }
		public AccountType AccountType { get; }

		[JsonConstructor]
		private Customer(string sportsbookCustomerId, string partnerCustomerId, string brandId,
			string currencyCode, string languageCode, AccountStatus accountStatus,
			SportsbookCustomerClassification sportsbookCustomerClassification,
			string partnerCustomerClassification, RegistrationDetails registrationDetails,
			PersonalInformation personalInformation, IEnumerable<Comment> comments,
			IEnumerable<AssociatedAccount> associatedAccounts,
			IDictionary<string, string> partnerCustomerAdditionalData,
			CustomerPreferences customerPreferences, AccountType accountType)
		{
			SportsbookCustomerId = sportsbookCustomerId;
			PartnerCustomerId = partnerCustomerId;
			BrandId = brandId;
			CurrencyCode = currencyCode;
			LanguageCode = languageCode;
			AccountStatus = accountStatus;
			SportsbookCustomerClassification = sportsbookCustomerClassification;
			PartnerCustomerClassification = partnerCustomerClassification;
			RegistrationDetails = registrationDetails;
			PersonalInformation = personalInformation;
			Comments = comments;
			AssociatedAccounts = associatedAccounts;
			PartnerCustomerAdditionalData = partnerCustomerAdditionalData;
			CustomerPreferences = customerPreferences;
			AccountType = accountType;
		}

		public static Customer Create(string sportsbookCustomerId, string partnerCustomerId, string brandId, string currencyCode, string languageCode, AccountStatus accountStatus, SportsbookCustomerClassification sportsbookCustomerClassification, string partnerCustomerClassification, RegistrationDetails registrationDetails, PersonalInformation personalInformation, IEnumerable<Comment> comments, IEnumerable<AssociatedAccount> associatedAccounts, IDictionary<string, string> partnerCustomerAdditionalData, CustomerPreferences customerPreferences, AccountType accountType = AccountType.Real)
		{
			return new Customer(sportsbookCustomerId, partnerCustomerId, brandId, currencyCode, languageCode, accountStatus, sportsbookCustomerClassification, partnerCustomerClassification, registrationDetails, personalInformation, comments, associatedAccounts, partnerCustomerAdditionalData, customerPreferences, accountType);
		}
	}
}