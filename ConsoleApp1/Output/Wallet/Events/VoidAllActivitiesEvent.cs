using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Wallet.Events
{
	public class VoidAllActivitiesEvent : IEvent
	{
		public string CorrelationId { get; }
		public string BrandId { get; }
		public long CouponId { get; }
		public DateTime DateTimeStamp { get; }
		public string RequestCorrelationId { get; }
		public string WalletActivityId { get; }
		public IDictionary<string, string> AdditionalData { get; }

		[JsonConstructor]
		private VoidAllActivitiesEvent(string correlationId, 
			string brandId, 
			long couponId, 
			DateTime dateTimeStamp, 
			string requestCorrelationId, 
			string walletActivityId, 
			IDictionary<string, string> additionalData)
		{
			CorrelationId = correlationId;
			BrandId = brandId;
			CouponId = couponId;
			DateTimeStamp = dateTimeStamp;
			WalletActivityId = walletActivityId;
			RequestCorrelationId = requestCorrelationId;
			AdditionalData = additionalData;
		}

		public static VoidAllActivitiesEvent Create(string correlationId, 
			string brandId, 
			long couponId, 
			DateTime dateTimeStamp, 
			string requestCorrelationId, 
			string walletActivityId, 
			IDictionary<string, string> additionalData)
		{
			return new VoidAllActivitiesEvent(correlationId, 
				brandId, 
				couponId, 
				dateTimeStamp, 
				requestCorrelationId, 
				walletActivityId,  
				additionalData);
		}
	}
}
