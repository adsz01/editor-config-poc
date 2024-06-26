namespace SB.Customer.Management.Contracts.Output.Customer
{
	public enum CustomerResponseCode
	{
		Success = 100,

		ValidationFailed = 200,

		CustomerAlreadyExists = 301,
		FailedCustomerIdMapping = 304,
		CustomerNotPartOfBrand = 305,
		InvalidCustomer = 306,
		InvalidUserContext = 307,
		UserContextExpired = 308,
		CustomerNoteNotFound = 309,
		CustomerNotFound = 310,
		InvalidAccountType = 311,
		CustomerFavouriteNotFound = 312,
		CustomerFavouriteLimitReached = 313,
		CustomerFavouriteAlreadyExists = 314,

		UnknownBrand = 800,

		OtherFailure = 900,
		CommunicationFailure = 901
	}
}
