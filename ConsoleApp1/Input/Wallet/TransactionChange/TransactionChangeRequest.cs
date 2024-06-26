using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Wallet.TransactionChange
{
	public class TransactionChangeRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string RequestedBy { get; }
		public string BrandId { get; }
		public string SportsbookCustomerId { get; }
		public IEnumerable<TransactionChangeAction> TransactionChangeActions { get; }
		public IDictionary<string, string> AdditionalData { get; }

		[JsonConstructor]
		private TransactionChangeRequest(
			ICorrelationRequest correlationRequest,
			string requestedBy,
			string brandId,
			string sportsbookCustomerId,
			IEnumerable<TransactionChangeAction> transactionChangeActions,
			IDictionary<string, string> additionalData)
		{
			CorrelationRequest = correlationRequest;
			RequestedBy = requestedBy;
			BrandId = brandId;
			SportsbookCustomerId = sportsbookCustomerId;
			TransactionChangeActions = transactionChangeActions;
			AdditionalData = additionalData;
		}

		public static TransactionChangeRequest Create(ICorrelationRequest correlationRequest, string requestedBy, string brandId,
			string sportsbookCustomerId, IEnumerable<TransactionChangeAction> transactionChangeActions,
			IDictionary<string, string> additionalData)
		{
			return new TransactionChangeRequest(correlationRequest: correlationRequest, requestedBy: requestedBy,
				brandId: brandId, sportsbookCustomerId: sportsbookCustomerId,
				transactionChangeActions: transactionChangeActions, additionalData: additionalData);
		}
	}
}
