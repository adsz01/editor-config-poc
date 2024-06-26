using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Wallet.Void.V2
{
	public class WalletVoidRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public string SportsbookCustomerId { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public IEnumerable<WalletVoidActivity> Activities { get; }
		public string RequestedBy { get; }
		public DateTime RequestedDate { get; }

		[JsonConstructor]
		private WalletVoidRequest(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			IDictionary<string, string> additionalData,
			IEnumerable<WalletVoidActivity> activities,
			string requestedBy,
			DateTime requestedDate)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			SportsbookCustomerId = sportsbookCustomerId;
			AdditionalData = additionalData;
			Activities = activities;
			RequestedBy = requestedBy;
			RequestedDate = requestedDate;
		}

		public static WalletVoidRequest Create(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			IDictionary<string, string> additionalData,
			IEnumerable<WalletVoidActivity> activities,
			string requestedBy,
			DateTime requestedDate)
		{
			return new WalletVoidRequest(
				correlationRequest: correlationRequest,
				brandId: brandId,
				sportsbookCustomerId: sportsbookCustomerId,
				additionalData: additionalData,
				activities: activities,
				requestedBy: requestedBy,
				requestedDate: requestedDate);
		}
	}
}
