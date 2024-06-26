namespace SB.Customer.Management.Contracts.Output.Transaction.Common.Action
{
	public enum TransactionActionType
	{
		Open = 1,
		Close = 2,
		Reopen = 3,
		ReopenAndClose = 4,
		Void = 5,
		ReopenAndVoid = 6
	}
}