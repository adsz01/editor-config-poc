using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class ChangeCustomerStatusRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public string SportsbookCustomerId { get; }
		public AccountStatus AccountStatus { get; }
		public CustomerStatusChangeReason ChangeReason { get; }
		public IEnumerable<string> AdditionalNotes { get; }
		public string ModifiedBy { get; }

		[JsonConstructor]
		private ChangeCustomerStatusRequest(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			AccountStatus accountStatus,
			CustomerStatusChangeReason changeReason,
			IEnumerable<string> additionalNotes,
			string modifiedBy
			)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			SportsbookCustomerId = sportsbookCustomerId;
			AccountStatus = accountStatus;
			ChangeReason = changeReason;
			AdditionalNotes = additionalNotes;
			ModifiedBy = modifiedBy;
		}

		public static ChangeCustomerStatusRequest Create(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			AccountStatus accountStatus,
			CustomerStatusChangeReason changeReason,
			IEnumerable<string> additionalNotes,
			string changedBy)
		=> new ChangeCustomerStatusRequest(correlationRequest,
										   brandId,
										   sportsbookCustomerId,
										   accountStatus,
										   changeReason,
										   additionalNotes,
										   changedBy);
	}

}
