using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common.Wallet;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Wallet.BalanceCheck
{
	public class WalletBalanceCheckRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public string SportsbookCustomerId { get; }
		public decimal RequiredAmount { get; }
		public string CurrencyCode { get; }
		public MoneyType MoneyType { get; }
		public BalanceCheckType BalanceCheckType { get; }
		public IDictionary<string, string> AdditionalData { get; }

		[JsonConstructor]
		private WalletBalanceCheckRequest(ICorrelationRequest correlationRequest, string brandId, string sportsbookCustomerId, decimal requiredAmount,
			string currencyCode, MoneyType moneyType, BalanceCheckType balanceCheckType, IDictionary<string, string> additionalData)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			SportsbookCustomerId = sportsbookCustomerId;
			RequiredAmount = requiredAmount;
			CurrencyCode = currencyCode;
			MoneyType = moneyType;
			BalanceCheckType = balanceCheckType;
			AdditionalData = additionalData;
		}

		public static WalletBalanceCheckRequest Create(ICorrelationRequest correlationRequest, string brandId, string sportsbookCustomerId, decimal requiredAmount,
			string currencyCode, MoneyType moneyType, BalanceCheckType balanceCheckType, IDictionary<string, string> additionalData)
				=> new WalletBalanceCheckRequest(correlationRequest, brandId, sportsbookCustomerId, requiredAmount, currencyCode, moneyType, balanceCheckType, additionalData);
	}
}
