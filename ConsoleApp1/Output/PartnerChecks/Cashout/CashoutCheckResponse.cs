using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.PartnerChecks.Cashout
{
	public class CashoutCheckResponse : IPartnerChecksResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public DateTime DateTimeStamp { get; }
		public IEnumerable<ResponseDetails> ResponseDetails { get; }

		[JsonConstructor]
		private CashoutCheckResponse(ICorrelationResponse correlationResponse, DateTime dateTimeStamp, IEnumerable<ResponseDetails> responseDetails)
		{
			CorrelationResponse = correlationResponse;
			DateTimeStamp = dateTimeStamp;
			ResponseDetails = responseDetails;
		}

		public static CashoutCheckResponse Create(ICorrelationResponse correlationResponse, DateTime dateTimeStamp, IEnumerable<ResponseDetails> responseDetails)
		{
			return new CashoutCheckResponse(correlationResponse, dateTimeStamp, responseDetails);
		}
	}
}
