using Newtonsoft.Json;
using System;

namespace SB.Customer.Management.Contracts.Output.Transaction.Common
{
	public class Amount
	{
		public decimal AmountValue { get; }
		public MoneyType MoneyType { get; }
		public string CurrencyCode { get; }

		[JsonConstructor]
		private Amount(decimal amountValue, MoneyType moneyType, string currencyCode)
		{
			AmountValue = amountValue;
			MoneyType = moneyType;
			CurrencyCode = currencyCode;
		}

		public static Amount Create(decimal amountValue, MoneyType moneyType, string currencyCode)
		{
			return new Amount(amountValue, moneyType, currencyCode);
		}

		public ResultCode Validate()
		{
			if (AmountValue < 0)
				return ResultCode.AmountShouldBeGreaterThanOrEqualToZero;

			return String.IsNullOrEmpty(CurrencyCode)
				? ResultCode.CurrencyCodeIsRequired
				: ResultCode.Success;
		}
	}
}
