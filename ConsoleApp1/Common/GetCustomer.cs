using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Output.Customer;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Common
{
	public class GetCustomer
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
		public AccountStatusChangeReason? StatusChangeReason { get; }
		public AccountType AccountType { get; }
		public IEnumerable<CustomerLimit> CustomerLimits { get; }
		public IEnumerable<CustomerFavourite> CustomerFavourites { get; }

		[JsonConstructor]
		private GetCustomer(string sportsbookCustomerId, string partnerCustomerId, string brandId,
			string currencyCode, string languageCode, AccountStatus accountStatus,
			SportsbookCustomerClassification sportsbookCustomerClassification,
			string partnerCustomerClassification, RegistrationDetails registrationDetails,
			PersonalInformation personalInformation, IEnumerable<Comment> comments,
			IEnumerable<AssociatedAccount> associatedAccounts,
			IDictionary<string, string> partnerCustomerAdditionalData,
			CustomerPreferences customerPreferences,
			AccountStatusChangeReason? statusChangeReason,
			AccountType accountType,
			IEnumerable<CustomerLimit> customerLimits,
			IEnumerable<CustomerFavourite> customerFavourites)
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
			StatusChangeReason = statusChangeReason;
			AccountType = accountType;
			CustomerLimits = customerLimits;
			CustomerFavourites = customerFavourites;
		}

		public static GetCustomer Create(string sportsbookCustomerId, string partnerCustomerId, string brandId, string currencyCode, string languageCode,
			AccountStatus accountStatus, SportsbookCustomerClassification sportsbookCustomerClassification, string partnerCustomerClassification, RegistrationDetails registrationDetails,
			PersonalInformation personalInformation, IEnumerable<Comment> comments, IEnumerable<AssociatedAccount> associatedAccounts, IDictionary<string, string> partnerCustomerAdditionalData,
			CustomerPreferences customerPreferences, AccountStatusChangeReason? statusChangeReason, AccountType accountType, IEnumerable<CustomerLimit> customerLimits, IEnumerable<CustomerFavourite> customerFavourites)
		{
			return new GetCustomer(sportsbookCustomerId, partnerCustomerId, brandId, currencyCode, languageCode, accountStatus,
				sportsbookCustomerClassification, partnerCustomerClassification, registrationDetails, personalInformation,
				comments, associatedAccounts, partnerCustomerAdditionalData, customerPreferences, statusChangeReason,
				accountType, customerLimits, customerFavourites);
		}
	}
}
