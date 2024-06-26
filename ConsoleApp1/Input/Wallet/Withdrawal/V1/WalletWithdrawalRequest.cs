using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Wallet.Withdrawal.V1
{
	public class WalletWithdrawalRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public string SportsbookCustomerId { get; }
		public string RequestedBy { get; }
		public DateTime RequestedDate { get; }
		public IDictionary<string, string> AdditionalData { get; }
		public IEnumerable<WalletWithdrawalActivity> Activities { get; }

		[JsonConstructor]
		private WalletWithdrawalRequest(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			string requestedBy,
			DateTime requestedDate,
			IDictionary<string, string> additionalData,
			IEnumerable<WalletWithdrawalActivity> activities)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			SportsbookCustomerId = sportsbookCustomerId;
			RequestedBy = requestedBy;
			RequestedDate = requestedDate;
			AdditionalData = additionalData;
			Activities = activities;
		}

		public static WalletWithdrawalRequest Create(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			string requestedBy,
			DateTime requestedDate,
			IDictionary<string, string> additionalData,
			IEnumerable<WalletWithdrawalActivity> activities) =>
			new WalletWithdrawalRequest(
				correlationRequest: correlationRequest,
				brandId: brandId,
				sportsbookCustomerId: sportsbookCustomerId,
				requestedBy: requestedBy,
				requestedDate: requestedDate,
				additionalData: additionalData,
				activities: activities);
	}
}