using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Customer.CustomerBehaviourAttributes
{
	public class ChangeCustomerProductBehaviourAttributesRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public IEnumerable<DeleteCustomerProductBehaviourAttributes> DeleteCustomerProductBehaviourAttributes { get; }
		public IEnumerable<AddCustomerProductBehaviourAttributes> AddCustomerProductBehaviourAttributes { get; }

		[JsonConstructor]
		private ChangeCustomerProductBehaviourAttributesRequest(
			ICorrelationRequest correlationRequest,
			string brandId,
			IEnumerable<DeleteCustomerProductBehaviourAttributes> deleteCustomerProductBehaviourAttributes,
			IEnumerable<AddCustomerProductBehaviourAttributes> addCustomerProductBehaviourAttributes)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			DeleteCustomerProductBehaviourAttributes = deleteCustomerProductBehaviourAttributes;
			AddCustomerProductBehaviourAttributes = addCustomerProductBehaviourAttributes;
		}

		public static ChangeCustomerProductBehaviourAttributesRequest Create(
			ICorrelationRequest correlationRequest,
			string brandId,
			IEnumerable<DeleteCustomerProductBehaviourAttributes> deleteCustomerProductBehaviourAttributes,
			IEnumerable<AddCustomerProductBehaviourAttributes> addCustomerProductBehaviourAttributes)
		{
			return new ChangeCustomerProductBehaviourAttributesRequest(
				correlationRequest,
				brandId,
				deleteCustomerProductBehaviourAttributes,
				addCustomerProductBehaviourAttributes);
		}
	}
}
