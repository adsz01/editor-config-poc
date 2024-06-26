using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System;
using System.Collections.Generic;
using Contract = SB.Customer.Management.Contracts.Common;

namespace SB.Customer.Management.Contracts.Input.PartnerChecks
{
	public class CashoutCheckRequest : ICommunityCorrelationRequest
	{
		public ICorrelationRequest CorrelationRequest { get; }
		public string BrandId { get; }
		public DateTime DateTimeStamp { get; }
		public string SportsbookCustomerId { get; }
		public decimal Amount { get; }
		public decimal RequestedStakeToRedeem { get; }
		public Contract.Wallet.MoneyType MoneyType { get; }
		public IEnumerable<Contract.Wallet.Fee> Fees { get; }
		public string CurrencyCode { get; }
		public Contract.PartnerChecks.Bet Bet { get; }
		public IDictionary<string, string> AdditionalData { get; }

		[JsonConstructor]
		private CashoutCheckRequest(ICorrelationRequest correlationRequest, string brandId, DateTime dateTimeStamp, string sportsbookCustomerId, decimal amount,
			decimal requestedStakeToRedeem, Contract.Wallet.MoneyType moneyType, IEnumerable<Contract.Wallet.Fee> fees, string currencyCode,
			Contract.PartnerChecks.Bet bet, IDictionary<string, string> additionalData)
		{
			CorrelationRequest = correlationRequest;
			BrandId = brandId;
			DateTimeStamp = dateTimeStamp;
			SportsbookCustomerId = sportsbookCustomerId;
			Amount = amount;
			RequestedStakeToRedeem = requestedStakeToRedeem;
			MoneyType = moneyType;
			Fees = fees;
			CurrencyCode = currencyCode;
			Bet = bet;
			AdditionalData = additionalData;
		}

		public static CashoutCheckRequest Create(ICorrelationRequest correlationRequest, string brandId, DateTime dateTimeStamp, string sportsbookCustomerId, decimal amount,
			decimal requestedStakeToRedeem, Contract.Wallet.MoneyType moneyType, IEnumerable<Contract.Wallet.Fee> fees, string currencyCode,
			Contract.PartnerChecks.Bet bet, IDictionary<string, string> additionalData)
		{
			return new CashoutCheckRequest(correlationRequest, brandId, dateTimeStamp, sportsbookCustomerId, amount, requestedStakeToRedeem, moneyType, fees, currencyCode, bet, additionalData);
		}

	}
}
