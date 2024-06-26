using SB.Community.Correlation.Interfaces;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public interface ICustomerResponse : ICommunityCorrelationResponse
	{
		CustomerResponseCode ResponseCode { get; }
	}
}
