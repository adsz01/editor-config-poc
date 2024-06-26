using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Common
{
	public class CustomerFilter
	{
		public string BrandId { get; }
		public string SportsbookCustomerId { get; }

		[JsonConstructor]
		private CustomerFilter(string brandId, string sportsbookCustomerId)
		{
			BrandId = brandId;
			SportsbookCustomerId = sportsbookCustomerId;
		}

		public static CustomerFilter Create(string brandId, string sportsbookCustomerId)
		{
			return new CustomerFilter(brandId, sportsbookCustomerId);
		}
	}
}
