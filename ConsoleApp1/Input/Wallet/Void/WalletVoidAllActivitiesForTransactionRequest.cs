using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Wallet.Void
{
	public class WalletVoidAllActivitiesForTransactionRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string WalletTransactionId { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public string RequestedBy { get; }
		public DateTime RequestedDate { get; }
		public string BrandId { get; }

		[JsonConstructor]
		private WalletVoidAllActivitiesForTransactionRequest(ICorrelationRequest correlationRequest, string brandId, string walletTransactionId, IDictionary<string, string> additionalData, string requestedBy, DateTime requestedDate)
		{
			CorrelationRequest = correlationRequest;
			WalletTransactionId = walletTransactionId;
			RequestedBy = requestedBy;
			RequestedDate = requestedDate;
			AdditionalData = additionalData;
			BrandId = brandId;
		}

		public static WalletVoidAllActivitiesForTransactionRequest Create(ICorrelationRequest correlationRequest,
			string brandId, string walletTransactionId, IDictionary<string, string> additionalData, string requestedBy, DateTime requestedDate)
		{
			return new WalletVoidAllActivitiesForTransactionRequest(correlationRequest, brandId, walletTransactionId, additionalData, requestedBy, requestedDate);
		}
	}
}
