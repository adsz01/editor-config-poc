using Newtonsoft.Json;
using System;

namespace SB.Customer.Management.Contracts.Common.Wallet
{
	public class TransactionAction
	{
		public TransactionActionType TransactionActionType { get; }
		public TransactionActionReason TransactionActionReason { get; }
		public DateTime TransactionActionDateTime { get; }

		[JsonConstructor]
		private TransactionAction(TransactionActionType transactionActionType,
			TransactionActionReason transactionActionReason,
			DateTime transactionActionDateTime)
		{
			TransactionActionType = transactionActionType;
			TransactionActionReason = transactionActionReason;
			TransactionActionDateTime = transactionActionDateTime;
		}

		public static TransactionAction Create(
			TransactionActionType transactionActionType,
			TransactionActionReason transactionActionReason,
			DateTime transactionActionDateTime)
		{
			return new TransactionAction(transactionActionType, transactionActionReason, transactionActionDateTime);
		}
	}
}