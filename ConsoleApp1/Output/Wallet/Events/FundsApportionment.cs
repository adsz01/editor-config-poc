using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Output.Transaction.Common;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Wallet.Events
{
	public class FundsApportionment
	{
		public string FundsApportionmentId { get; }
		public Amount UserCurrencyAmount { get; }

		public Amount BaseCurrencyAmount { get; }

		public decimal ExchangeRate { get; }

		public MoneyType MoneyType { get; }

		public Dictionary<string, string> AdditionalData { get; }

		[JsonConstructor]
		private FundsApportionment(Amount userCurrencyAmount, Amount baseCurrencyAmount, decimal exchangeRate,
			MoneyType moneyType, Dictionary<string, string> additionalData, string fundsApportionmentId)
		{
			UserCurrencyAmount = userCurrencyAmount;
			BaseCurrencyAmount = baseCurrencyAmount;
			ExchangeRate = exchangeRate;
			MoneyType = moneyType;
			AdditionalData = additionalData;
			FundsApportionmentId = fundsApportionmentId;
		}

		public static FundsApportionment Create(Amount userCurrencyAmount, Amount baseCurrencyAmount,
			decimal exchangeRate,
			MoneyType moneyType, Dictionary<string, string> additionalData, string fundsApportionmentId) =>
			new FundsApportionment(userCurrencyAmount, baseCurrencyAmount, exchangeRate,
				moneyType, additionalData, fundsApportionmentId);
	}
}
