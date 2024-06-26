using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Output.Transaction.Common.Action;
using SB.Customer.Management.Contracts.Output.Transaction.Deposit;
using SB.Customer.Management.Contracts.Output.Transaction.Withdrawal;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Transaction
{
	public class WalletTransaction
	{
		public Guid Id { get; }
		public string BrandId { get; }
		public string SportsbookCustomerId { get; }
		public string RequestedBy { get; }
		public DateTime RequestedDate { get; }
		public IEnumerable<WalletWithdrawalActivity> WithdrawalActivities { get; }
		public IEnumerable<WalletDepositActivity> DepositActivities { get; }
		public TransactionAction LastTransactionAction { get; }

		[JsonConstructor]
		private WalletTransaction(
			Guid id,
			string brandId,
			string sportsbookCustomerId,
			string requestedBy,
			DateTime requestedDate,
			IEnumerable<WalletWithdrawalActivity> withdrawalActivities,
			IEnumerable<WalletDepositActivity> depositActivities,
			TransactionAction lastTransactionAction)
		{
			Id = id;
			BrandId = brandId;
			SportsbookCustomerId = sportsbookCustomerId;
			RequestedBy = requestedBy;
			RequestedDate = requestedDate;
			WithdrawalActivities = withdrawalActivities;
			DepositActivities = depositActivities;
			LastTransactionAction = lastTransactionAction;
		}

		public static WalletTransaction Create(
			Guid id,
			string brandId,
			string sportsbookCustomerId,
			string requestedBy,
			DateTime requestedDate,
			IEnumerable<WalletWithdrawalActivity> withdrawalActivities,
			IEnumerable<WalletDepositActivity> depositActivities,
			TransactionAction lastTransactionAction)
		{
			return new WalletTransaction(
				id: id,
				brandId: brandId,
				sportsbookCustomerId: sportsbookCustomerId,
				requestedBy: requestedBy,
				requestedDate: requestedDate,
				withdrawalActivities: withdrawalActivities,
				depositActivities: depositActivities,
				lastTransactionAction: lastTransactionAction);
		}
	}
}