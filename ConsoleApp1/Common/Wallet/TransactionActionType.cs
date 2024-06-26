namespace SB.Customer.Management.Contracts.Common.Wallet
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