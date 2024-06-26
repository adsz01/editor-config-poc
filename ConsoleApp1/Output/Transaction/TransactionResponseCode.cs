namespace SB.Customer.Management.Contracts.Output.Transaction
{
	public enum TransactionResponseCode
	{
		Success = 100,
		ValidationFailed = 200,

		DataSegregationBreachDetected = 301,

		OtherFailure = 900,
		CommunicationFailure = 901
	}
}
