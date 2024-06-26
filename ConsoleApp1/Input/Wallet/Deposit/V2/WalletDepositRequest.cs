using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;

namespace SB.Customer.Management.Contracts.Input.Wallet.Deposit.V2
{
	public class WalletDepositRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public string SportsbookCustomerId { get; }
		public IEnumerable<WalletDepositActivity> Activities { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public string RequestedBy { get; }
		public DateTime RequestedDate { get; }

		[JsonConstructor]
		private WalletDepositRequest(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			IDictionary<string, string> additionalData,
			IEnumerable<WalletDepositActivity> activities,
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

		public static WalletDepositRequest Create(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			IDictionary<string, string> additionalData,
			IEnumerable<WalletDepositActivity> activities,
			string requestedBy,
			DateTime requestedDate)
		{
			return new WalletDepositRequest(
				correlationRequest: correlationRequest,
				brandId: brandId,
				sportsbookCustomerId: sportsbookCustomerId,
				additionalData: additionalData,
				activities: activities.ToList(),
				requestedBy: requestedBy,
				requestedDate: requestedDate);
		}
	}
}