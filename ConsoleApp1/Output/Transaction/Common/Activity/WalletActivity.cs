using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Output.Transaction.Common.Action;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Transaction.Common.Activity
{
	public abstract class WalletActivity
	{
		public Guid Id { get; }
		public Amount Amount { get; }
		public WalletActivityState State { get; }
		public Guid VoidActivityId { get; }
		public DateTime? VoidActivityDateTime { get; }
		public string AdditionalNotes { get; }
		public DateTime DateTime { get; }
		public IEnumerable<Fee> Fees { get; }
		public long BetId { get; protected set; }
		public WalletActivityResult Result { get; }
		public TransactionAction TransactionAction { get; }


		[JsonConstructor]
		protected WalletActivity(
			Guid id,
			Amount amount,
			WalletActivityState state,
			DateTime dateTime,
			string additionalNotes,
			long betId,
			WalletActivityResult result,
			Guid voidActivityId,
			TransactionAction transactionAction,
			IEnumerable<Fee> fees,
			DateTime? voidActivityDateTime)
		{
			Id = id;
			Amount = amount;
			State = state;
			DateTime = dateTime;
			AdditionalNotes = additionalNotes;
			BetId = betId;
			Result = result;
			VoidActivityId = voidActivityId;
			TransactionAction = transactionAction;
			Fees = fees;
			VoidActivityDateTime = voidActivityDateTime;
		}
	}
}