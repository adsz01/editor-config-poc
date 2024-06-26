namespace SB.Customer.Management.Contracts.Output.Wallet
{
	public enum WalletResponseCode
	{
		Success = 100,
		ValidationFailed = 200,
		InvalidCustomer = 201,
		CustomerNotLoggedIn = 202,
		FailedCustomerIdMapping = 203,
		InvalidBrand = 204,
		MalformedRequest = 205,
		NotEnoughFunds = 301,
		GeographicallyOutOfBounds = 302,
		UnverifiedCustomer = 303,
		TransactionLimitExceeded = 304,
		FailedToSaveRequestAudit = 400,
		FailedToAcquireLock = 401,
		FailedToSaveTransaction = 402,
		FailedToSaveActivitiesAndTransactionsResults = 403,
		FailedToSaveActivitiesResults = 404,
		FailedToSaveTransactionsResults = 405,
		DomainValidationError = 406,
		FailedToReleaseLock = 407,
		TransactionMappingsFoundCorrupted = 408,
		FailedToGetIdMappings = 409,
		FailedToSaveResponseAudit = 410,
		FailedToSaveTransactionAction = 411,
		FailedToSaveTransactionActionResults = 412,
		MismatchInNumberOfWalletTransactions = 413,
		FailedToSaveVoidActivities = 414,
		FailedToGetSavedTransactionChangeResponse = 415,
		FailedToGetPreviousResponse = 416,
		NotAllActivitiesSucceeded = 417,
		Failed = 900,
		CommunicationFailure = 901,
		FailedILCall = 902
	}
}