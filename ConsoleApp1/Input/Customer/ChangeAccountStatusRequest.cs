using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class ChangeAccountStatusRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public string SportsbookCustomerId { get; }
		public AccountStatus AccountStatus { get; }
		public AccountStatusChangeReason ChangeReason { get; }
		public string ModifiedBy { get; }

		[JsonConstructor]
		private ChangeAccountStatusRequest(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			AccountStatus accountStatus,
			AccountStatusChangeReason changeReason,
			string modifiedBy)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			SportsbookCustomerId = sportsbookCustomerId;
			AccountStatus = accountStatus;
			ChangeReason = changeReason;
			ModifiedBy = modifiedBy;
		}

		public static ChangeAccountStatusRequest Create(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			AccountStatus accountStatus,
			AccountStatusChangeReason changeReason,
			string modifiedBy)
			=> new ChangeAccountStatusRequest(
				correlationRequest,
				brandId,
				sportsbookCustomerId,
				accountStatus,
				changeReason,
				modifiedBy);
	}
}