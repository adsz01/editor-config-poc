using Newtonsoft.Json;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Customer.CustomerBehaviourAttributes
{
	public class AddCustomerProductBehaviourAttributes
	{
		public string SportsbookCustomerId { get; }
		public IEnumerable<AddProductBehaviourAttribute> AddProductBehaviourAttributes { get; }

		[JsonConstructor]
		private AddCustomerProductBehaviourAttributes(
			string sportsbookCustomerId,
			IEnumerable<AddProductBehaviourAttribute> addProductBehaviourAttributes)
		{
			SportsbookCustomerId = sportsbookCustomerId;
			AddProductBehaviourAttributes = addProductBehaviourAttributes;
		}

		public static AddCustomerProductBehaviourAttributes Create(
			string sportsbookCustomerId,
			IEnumerable<AddProductBehaviourAttribute> addProductBehaviourAttributes)
		{
			return new AddCustomerProductBehaviourAttributes(sportsbookCustomerId, addProductBehaviourAttributes);
		}
	}
}
