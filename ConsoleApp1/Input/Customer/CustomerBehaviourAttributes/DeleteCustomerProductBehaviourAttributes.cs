using Newtonsoft.Json;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Customer.CustomerBehaviourAttributes
{
	public class DeleteCustomerProductBehaviourAttributes
	{
		public string SportsbookCustomerId { get; }
		public IEnumerable<DeleteProductBehaviourAttribute> DeleteProductBehaviourAttributes { get; }

		[JsonConstructor]
		private DeleteCustomerProductBehaviourAttributes(
			string sportsbookCustomerId,
			IEnumerable<DeleteProductBehaviourAttribute> deleteProductBehaviourAttributes)
		{
			SportsbookCustomerId = sportsbookCustomerId;
			DeleteProductBehaviourAttributes = deleteProductBehaviourAttributes;
		}

		public static DeleteCustomerProductBehaviourAttributes Create(
			string sportsbookCustomerId,
			IEnumerable<DeleteProductBehaviourAttribute> deleteProductBehaviourAttributes)
		{
			return new DeleteCustomerProductBehaviourAttributes(sportsbookCustomerId, deleteProductBehaviourAttributes);
		}
	}
}
