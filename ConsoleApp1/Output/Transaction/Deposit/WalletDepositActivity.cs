using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Output.Transaction.Common;
using SB.Customer.Management.Contracts.Output.Transaction.Common.Action;
using SB.Customer.Management.Contracts.Output.Transaction.Common.Activity;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Transaction.Deposit
{
	public class WalletDepositActivity : WalletActivity
	{
		public DepositType DepositType { get; }
		public string CashoutId { get; }

		[JsonConstructor]
		protected WalletDepositActivity(Guid id,
			Amount amount,
			DepositType depositType,
			WalletActivityState state,
			DateTime dateTime,
			string additionalNotes,
			long betId,
			WalletActivityResult result,
			Guid voidActivityId,
			TransactionAction transactionAction,
			IEnumerable<Fee> fees,
			DateTime? voidActivityDateTime,
			string cashoutId) :
			base(id: id,
			amount: amount,
			state: state,
			dateTime: dateTime,
			additionalNotes: additionalNotes,
			betId: betId,
			result: result,
			voidActivityId: voidActivityId,
			transactionAction: transactionAction,
			fees: fees,
			voidActivityDateTime: voidActivityDateTime)
		{
			DepositType = depositType;
			CashoutId = cashoutId;
		}

		public static WalletDepositActivity Create(Guid id,
			Amount amount,
			DepositType depositType,
			WalletActivityState state,
			DateTime dateTime,
			string additionalNotes,
			long betId,
			WalletActivityResult result,
			Guid voidActivityId,
			TransactionAction transactionAction,
			IEnumerable<Fee> fees,
			DateTime? voidActivityDateTime,
			string cashoutId)
		{
			return new WalletDepositActivity(
				id: id,
				amount: amount,
				depositType: depositType,
				state: state,
				dateTime: dateTime,
				additionalNotes: additionalNotes,
				betId: betId,
				result: result,
				voidActivityId: voidActivityId,
				transactionAction: transactionAction,
				fees: fees,
				voidActivityDateTime: voidActivityDateTime,
				cashoutId: cashoutId);
		}
	}
}