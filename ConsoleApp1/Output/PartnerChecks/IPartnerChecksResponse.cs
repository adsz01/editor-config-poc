using SB.Community.Correlation.Interfaces;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.PartnerChecks
{
	public interface IPartnerChecksResponse : ICommunityCorrelationResponse
	{
		DateTime DateTimeStamp { get; }
		IEnumerable<ResponseDetails> ResponseDetails { get; }
	}
}
