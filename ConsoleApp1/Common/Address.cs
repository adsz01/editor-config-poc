using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Common
{
	public class Address
	{
		public string CountryCode { get; }
		public string State { get; }
		public string City { get; }

		[JsonConstructor]
		private Address(string countryCode, string state, string city)
		{
			CountryCode = countryCode;
			State = state;
			City = city;
		}

		public static Address Create(string countryCode, string state, string city)
		{
			return new Address(countryCode, state, city);
		}

	}
}
