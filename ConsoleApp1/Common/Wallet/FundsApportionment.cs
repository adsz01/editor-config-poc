using Newtonsoft.Json;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Common.Wallet
{
	public class FundsApportionment
	{
		public decimal Amount { get; }
		public MoneyType MoneyType { get; }
		public Dictionary<string, string> AdditionalData { get; }

		[JsonConstructor]
		private FundsApportionment(
			decimal amount,
			MoneyType moneyType,
			Dictionary<string, string> additionalData)
		{
			Amount = amount;
			MoneyType = moneyType;
			AdditionalData = additionalData;
		}

		public static FundsApportionment Create(
			decimal amount,
			MoneyType moneyType,
			Dictionary<string, string> additionalData)
		{
			return new FundsApportionment(
				amount,
				moneyType,
				additionalData);
		}
	}
}