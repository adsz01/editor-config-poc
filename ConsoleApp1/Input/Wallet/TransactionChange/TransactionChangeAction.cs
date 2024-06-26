using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common.Wallet;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Input.Wallet.TransactionChange
{
	public class TransactionChangeAction
	{
		public Guid SportsbookTransactionId { get; }
		public TransactionAction TransactionAction { get; }
		public IDictionary<string, string> AdditionalData { get; }

		[JsonConstructor]
		private TransactionChangeAction(Guid sportsbookTransactionId, TransactionAction transactionAction, IDictionary<string, string> additionalData)
		{
			SportsbookTransactionId = sportsbookTransactionId;
			TransactionAction = transactionAction;
			AdditionalData = additionalData;
		}

		public static TransactionChangeAction Create(Guid sportsbookTransactionId, TransactionAction transactionAction, IDictionary<string, string> additionalData)
		{
			return new TransactionChangeAction(sportsbookTransactionId, transactionAction, additionalData);
		}
	}
}
