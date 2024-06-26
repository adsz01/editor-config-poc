using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Wallet.Void
{
	public class WalletVoidAllActivitiesRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public long CouponId { get; }
		public string WalletActivityId { get; }
		public string RequestCorrelationId { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public string RequestedBy { get; }
		public DateTime RequestedDate { get; }

		[JsonConstructor]
		private WalletVoidAllActivitiesRequest(ICorrelationRequest correlationRequest, 
			string brandId, 
			long couponId,
			string walletActivityId, 
			string requestCorrelationId,
			IDictionary<string, string> additionalData, 
			string requestedBy, 
			DateTime requestedDate)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			CouponId = couponId;
			WalletActivityId = walletActivityId;
			RequestCorrelationId = requestCorrelationId;
			RequestedBy = requestedBy;
			RequestedDate = requestedDate;
			AdditionalData = additionalData;
		}

		public static WalletVoidAllActivitiesRequest Create(ICorrelationRequest correlationRequest, 
			string brandId, 
			long couponId,
			string walletActivityId, 
			string requestCorrelationId,
			IDictionary<string, string> additionalData, 
			string requestedBy, 
			DateTime requestedDate)
		{
			return new WalletVoidAllActivitiesRequest(correlationRequest, 
				brandId, 
				couponId,
				walletActivityId, 
				requestCorrelationId, 
				additionalData, 
				requestedBy, 
				requestedDate);
		}
	}
}
