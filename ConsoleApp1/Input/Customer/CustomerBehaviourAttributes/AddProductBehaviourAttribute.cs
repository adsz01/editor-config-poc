using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Input.Customer.CustomerBehaviourAttributes
{
	public class AddProductBehaviourAttribute
	{
		public string Tag { get; }
		public ProductBehaviourAttributeData ProductBehaviourAttributeData { get; }

		[JsonConstructor]
		private AddProductBehaviourAttribute(string tag, ProductBehaviourAttributeData productBehaviourAttributeData)
		{
			Tag = tag;
			ProductBehaviourAttributeData = productBehaviourAttributeData;
		}

		public static AddProductBehaviourAttribute Create(string tag, ProductBehaviourAttributeData productBehaviourAttributeData)
		{
			return new AddProductBehaviourAttribute(tag, productBehaviourAttributeData);
		}
	}
}
