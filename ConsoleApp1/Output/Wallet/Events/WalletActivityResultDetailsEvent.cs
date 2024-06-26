using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Wallet.Events
{
	public class WalletActivityResultDetailsEvent : IEvent
	{
		public string CorrelationId { get; }
		public string BrandId { get; }
		public DateTime DateTimeStamp { get; }
		public IEnumerable<FundsApportionment> FundsApportionments { get; }
		public string SportsbookTransactionId { get; }
		public string ActivityId { get; }
		public string WalletActivityResultId { get; }
		public DateTime ResultDateTime { get; }
		public ActivityTransactionType ActivityTransactionType { get; }
		public ActivityType ActivityType { get; }
		public Bet Bet { get; }

		[JsonConstructor]
		private WalletActivityResultDetailsEvent(string correlationId, string brandId, DateTime dateTimeStamp,
			IEnumerable<FundsApportionment> fundsApportionments,
			string sportsbookTransactionId, string activityId, string walletActivityResultId,
			DateTime resultDateTime, ActivityTransactionType activityTransactionType, ActivityType activityType, Bet bet)
		{
			CorrelationId = correlationId;
			BrandId = brandId;
			DateTimeStamp = dateTimeStamp;
			FundsApportionments = fundsApportionments;
			SportsbookTransactionId = sportsbookTransactionId;
			ActivityId = activityId;
			WalletActivityResultId = walletActivityResultId;
			ResultDateTime = resultDateTime;
			ActivityTransactionType = activityTransactionType;
			ActivityType = activityType;
			Bet = bet;
		}

		public static WalletActivityResultDetailsEvent Create(string correlationId, string brandId, DateTime dateTimeStamp,
			IEnumerable<FundsApportionment> fundsApportionments,
			string sportsbookTransactionId, string activityId, string walletActivityResultId,
			DateTime resultDateTime, ActivityTransactionType activityTransactionType, ActivityType activityType, Bet bet) =>
			new WalletActivityResultDetailsEvent(correlationId, brandId, dateTimeStamp, fundsApportionments, sportsbookTransactionId, activityId,
				walletActivityResultId,
				resultDateTime, activityTransactionType, activityType, bet);
	}
}
