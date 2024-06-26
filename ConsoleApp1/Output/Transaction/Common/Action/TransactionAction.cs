using Newtonsoft.Json;
using System;

namespace SB.Customer.Management.Contracts.Output.Transaction.Common.Action
{
	public class TransactionAction
	{
		public Guid Id { get; }
		public TransactionActionType Type { get; }
		public TransactionActionReason Reason { get; }
		public DateTime DateTime { get; }
		public TransactionActionResult Result { get; protected set; }

		[JsonConstructor]
		protected TransactionAction(
			Guid id,
			TransactionActionType type,
			TransactionActionReason reason,
			DateTime dateTime,
			TransactionActionResult result)
		{
			Id = id;
			Type = type;
			Reason = reason;
			DateTime = dateTime;
			Result = result;
		}

		public static TransactionAction Create(
			Guid id,
			TransactionActionType type,
			TransactionActionReason reason,
			DateTime dateTime,
			TransactionActionResult result)
		{
			return new TransactionAction(
				id: id,
				type: type,
				reason: reason,
				dateTime: dateTime,
				result: result);
		}
	}
}