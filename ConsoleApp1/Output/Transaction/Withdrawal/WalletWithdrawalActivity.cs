using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Output.Transaction.Common;
using SB.Customer.Management.Contracts.Output.Transaction.Common.Action;
using SB.Customer.Management.Contracts.Output.Transaction.Common.Activity;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Transaction.Withdrawal
{
	public class WalletWithdrawalActivity : WalletActivity
	{
		public WithdrawalType WithdrawalType { get; }

		[JsonConstructor]
		private WalletWithdrawalActivity(Guid id,
			Amount amount,
			WithdrawalType withdrawalType,
			WalletActivityState state,
			DateTime dateTime,
			string additionalNotes,
			long betId,
			WalletActivityResult result,
			Guid voidActivityId,
			TransactionAction transactionAction,
			IEnumerable<Fee> fees,
			DateTime? voidActivityDateTime)
			: base(id: id,
			amount: amount,
			state: state,
			dateTime: dateTime,
			additionalNotes: additionalNotes,
			betId: betId,
			result: result,
			voidActivityId: voidActivityId,
			transactionAction: transactionAction,
			fees: fees,
			voidActivityDateTime: voidActivityDateTime
			)
		{
			WithdrawalType = withdrawalType;
		}

		public static WalletWithdrawalActivity Create(Guid id,
			Amount amount,
			WithdrawalType withdrawalType,
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
			return new WalletWithdrawalActivity(
				id: id,
				amount: amount,
				withdrawalType: withdrawalType,
				state: state,
				dateTime: dateTime,
				additionalNotes: additionalNotes,
				betId: betId,
				result: result,
				voidActivityId: voidActivityId,
				transactionAction: transactionAction,
				fees: fees,
				voidActivityDateTime: voidActivityDateTime);
		}
	}
}