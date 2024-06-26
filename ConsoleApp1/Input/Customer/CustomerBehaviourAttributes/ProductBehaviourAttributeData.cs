using Newtonsoft.Json;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Customer.CustomerBehaviourAttributes
{
	public class ProductBehaviourAttributeData
	{
		public IDictionary<string, string> AttributeData { get; }

		[JsonConstructor]
		private ProductBehaviourAttributeData(IDictionary<string, string> attributeData) => AttributeData = attributeData;

		public static ProductBehaviourAttributeData Create(IDictionary<string, string> attributeData) =>
			new ProductBehaviourAttributeData(attributeData);
	}
}
