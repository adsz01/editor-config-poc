using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Wallet.Void
{
	public class WalletVoidActivitiesRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public string RequestCorrelationId { get; }
		public string WalletActivityId { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public string RequestedBy { get; }
		public DateTime RequestedDate { get; }

		[JsonConstructor]
		private WalletVoidActivitiesRequest(ICorrelationRequest correlationRequest, string brandId, string requestCorrelationId, string walletActivityId,
			IDictionary<string, string> additionalData, string requestedBy, DateTime requestedDate)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			RequestCorrelationId = requestCorrelationId;
			RequestedBy = requestedBy;
			RequestedDate = requestedDate;
			WalletActivityId = walletActivityId;
			AdditionalData = additionalData;
		}

		public static WalletVoidActivitiesRequest Create(ICorrelationRequest correlationRequest, string brandId, string requestCorrelationId, string walletActivityId,
			IDictionary<string, string> additionalData, string requestedBy, DateTime requestedDate)
		{
			return new WalletVoidActivitiesRequest(correlationRequest, brandId, requestCorrelationId, walletActivityId, additionalData, requestedBy, requestedDate);
		}
	}
}