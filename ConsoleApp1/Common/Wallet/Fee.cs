using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Common.Wallet
{
	public class Fee
	{
		public decimal Amount { get; }
		public string CurrencyCode { get; }
		public FeeType FeeType { get; }

		[JsonConstructor]
		private Fee(decimal amount, string currencyCode, FeeType feeType)
		{
			Amount = amount;
			CurrencyCode = currencyCode;
			FeeType = feeType;
		}

		public static Fee Create(decimal amount, string currencyCode, FeeType feeType) =>
			new Fee(amount, currencyCode, feeType);
	}
}