using SB.Community.Correlation.Interfaces;

namespace SB.Customer.Management.Contracts.Output.Transaction
{
	public interface ITransactionResponse : ICommunityCorrelationResponse
	{
		TransactionResponseCode ResponseCode { get; }
	}
}
