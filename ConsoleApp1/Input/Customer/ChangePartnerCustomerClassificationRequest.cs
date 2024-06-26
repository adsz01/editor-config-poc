using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class ChangePartnerCustomerClassificationRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public string SportsbookCustomerId { get; }
		public string PartnerCustomerClassification { get; }
		public PartnerClassificationChangeReason ChangeReason { get; }
		public IEnumerable<string> AdditionalNotes { get; }
		public string ChangedBy { get; }

		[JsonConstructor]
		private ChangePartnerCustomerClassificationRequest(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			string partnerCustomerClassification,
			PartnerClassificationChangeReason changeReason,
			IEnumerable<string> additionalNotes,
			string changedBy)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			SportsbookCustomerId = sportsbookCustomerId;
			PartnerCustomerClassification = partnerCustomerClassification;
			ChangeReason = changeReason;
			AdditionalNotes = additionalNotes;
			ChangedBy = changedBy;
		}

		public static ChangePartnerCustomerClassificationRequest Create(
			ICorrelationRequest correlationRequest,
			string brandId,
			string sportsbookCustomerId,
			string partnerCustomerClassification,
			PartnerClassificationChangeReason changeReason,
			IEnumerable<string> additionalNotes,
			string changedBy)
		=> new ChangePartnerCustomerClassificationRequest(correlationRequest,
														  brandId,
														  sportsbookCustomerId,
														  partnerCustomerClassification,
														  changeReason,
														  additionalNotes,
														  changedBy);
	}

}
