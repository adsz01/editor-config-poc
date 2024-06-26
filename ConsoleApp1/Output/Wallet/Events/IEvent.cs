using System;

namespace SB.Customer.Management.Contracts.Output.Wallet.Events
{
	public interface IEvent
	{
		string CorrelationId { get; }
		string BrandId { get; }
		DateTime DateTimeStamp { get; }
	}
}
