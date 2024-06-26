using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Input.Customer.CustomerBehaviourAttributes
{
	public class DeleteProductBehaviourAttribute
	{
		public string Id { get; }
		public string Tag { get; }

		[JsonConstructor]
		private DeleteProductBehaviourAttribute(string id, string tag)
		{
			Id = id;
			Tag = tag;
		}

		public static DeleteProductBehaviourAttribute Create(string id, string tag)
		{
			return new DeleteProductBehaviourAttribute(id, tag);
		}
	}
}
