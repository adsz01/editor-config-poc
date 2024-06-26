using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class ChangeSportsbookCustomerClassificationRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public string SportsbookCustomerId { get; }
		public SportsbookCustomerClassification SportsbookCustomerClassification { get; }
		public SportsbookClassificationChangeReason ChangeReason { get; }
		public string ModifiedBy { get; }

		[JsonConstructor]
		private ChangeSportsbookCustomerClassificationRequest(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			SportsbookCustomerClassification sportsbookCustomerClassification,
			SportsbookClassificationChangeReason changeReason,
			string modifiedBy)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			SportsbookCustomerId = sportsbookCustomerId;
			SportsbookCustomerClassification = sportsbookCustomerClassification;
			ChangeReason = changeReason;
			ModifiedBy = modifiedBy;
		}

		public static ChangeSportsbookCustomerClassificationRequest Create(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			SportsbookCustomerClassification sportsbookCustomerClassification,
			SportsbookClassificationChangeReason changeReason,
			string modifiedBy)
		=> new ChangeSportsbookCustomerClassificationRequest(
			correlationRequest,
			brandId,
			sportsbookCustomerId,
			sportsbookCustomerClassification,
			changeReason,
			modifiedBy);
	}
}