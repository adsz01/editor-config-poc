using Newtonsoft.Json;
using System;

namespace SB.Customer.Management.Contracts.Common
{
	public class AssociatedAccount
	{
		public string SportsbookCustomerId { get; }
		public string PartnerCustomerId { get; }
		public AssociationReason AssociationReason { get; }
		public string AssociatedBy { get; }
		public DateTime AssociatedDateTime { get; }

		[JsonConstructor]
		private AssociatedAccount(string sportsbookCustomerId, string partnerCustomerId, AssociationReason associationReason, string associatedBy, DateTime associatedDateTime)
		{
			SportsbookCustomerId = sportsbookCustomerId;
			PartnerCustomerId = partnerCustomerId;
			AssociationReason = associationReason;
			AssociatedBy = associatedBy;
			AssociatedDateTime = associatedDateTime;
		}

		public static AssociatedAccount Create(string sportsbookCustomerId, string partnerCustomerId, AssociationReason associationReason, string associatedBy, DateTime associatedDateTime)
		{
			return new AssociatedAccount(sportsbookCustomerId, partnerCustomerId, associationReason, associatedBy, associatedDateTime);
		}

	}
}
