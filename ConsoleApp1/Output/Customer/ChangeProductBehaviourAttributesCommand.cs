using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Input.Customer.CustomerBehaviourAttributes;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	//TODO these contracts should be removed and get referenced from a nugget published from SB.Customer.Management.Engine when it is ready (https://edgealpha.corpsson.com/browse/STBT-7670)
	public class ChangeCustomerProductBehaviourAttributesCommand
	{
		public string CorrelationId { get; }
		public string BrandId { get; }
		public DateTime DateTimeStamp { get; }
		public IEnumerable<DeleteCustomerProductBehaviourAttributes> DeleteCustomerProductBehaviourAttributes { get; }
		public IEnumerable<AddCustomerProductBehaviourAttributes> AddCustomerProductBehaviourAttributes { get; }

		[JsonConstructor]
		private ChangeCustomerProductBehaviourAttributesCommand(string correlationId, string brandId, DateTime dateTimeStamp, IEnumerable<DeleteCustomerProductBehaviourAttributes> deleteCustomerProductBehaviourAttributes, IEnumerable<AddCustomerProductBehaviourAttributes> addCustomerProductBehaviourAttributes)
		{
			CorrelationId = correlationId;
			BrandId = brandId;
			DateTimeStamp = dateTimeStamp;
			DeleteCustomerProductBehaviourAttributes = deleteCustomerProductBehaviourAttributes;
			AddCustomerProductBehaviourAttributes = addCustomerProductBehaviourAttributes;
		}
		public static ChangeCustomerProductBehaviourAttributesCommand Create(string correlationId, string brandId, DateTime dateTimeStamp, IEnumerable<DeleteCustomerProductBehaviourAttributes> deleteCustomerProductBehaviourAttributes, IEnumerable<AddCustomerProductBehaviourAttributes> addCustomerProductBehaviourAttributes)
		{
			return new ChangeCustomerProductBehaviourAttributesCommand(correlationId, brandId, dateTimeStamp, deleteCustomerProductBehaviourAttributes, addCustomerProductBehaviourAttributes);
		}
	}

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
