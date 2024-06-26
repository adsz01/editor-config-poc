
using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Common
{
	public class PropertyValue<T>
	{
		public PropertyValueType Type { get; }
		public T Value { get; }

		[JsonConstructor]
		private PropertyValue(PropertyValueType type, T value)
		{
			Type = type;
			Value = value;
		}

		public static PropertyValue<T> Create(PropertyValueType type, T value)
		{
			return new PropertyValue<T>(type, value);
		}
	}
}
