using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Output.Wallet.Events
{
	public class Amount
	{
		public decimal AmountValue { get; }
		public string CurrencyCode { get; }

		[JsonConstructor]
		private Amount(decimal amountValue, string currencyCode)
		{
			AmountValue = amountValue;
			CurrencyCode = currencyCode;
		}

		public static Amount Create(decimal amountValue, string currencyCode)
		{
			return new Amount(amountValue, currencyCode);
		}
	}
}
