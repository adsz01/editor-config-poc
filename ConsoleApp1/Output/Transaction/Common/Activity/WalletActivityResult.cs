using Newtonsoft.Json;
using System;

namespace SB.Customer.Management.Contracts.Output.Transaction.Common.Activity
{
	public class WalletActivityResult
	{
		public Guid Id { get; }
		public ResultCode ResultCode { get; }
		public string AdditionalNotes { get; }
		public Guid WalletActivityId { get; }
		public Guid SportsbookWalletTransactionId { get; }
		public DateTime ResultDateTime { get; }

		[JsonConstructor]
		protected WalletActivityResult(
			Guid id,
			ResultCode resultCode,
			string additionalNotes,
			Guid walletActivityId,
			Guid sportsbookWalletTransactionId,
			DateTime resultDateTime)
		{
			Id = id;
			ResultCode = resultCode;
			AdditionalNotes = additionalNotes;
			WalletActivityId = walletActivityId;
			SportsbookWalletTransactionId = sportsbookWalletTransactionId;
			ResultDateTime = resultDateTime;
		}

		public static WalletActivityResult Create(
			Guid id,
			ResultCode resultCode,
			string additionalNotes,
			Guid walletActivityId,
			Guid sportsbookWalletTransactionId,
			DateTime resultDateTime)
		{
			return new WalletActivityResult(
				id: id,
				resultCode: resultCode,
				additionalNotes: additionalNotes,
				walletActivityId: walletActivityId,
				sportsbookWalletTransactionId: sportsbookWalletTransactionId,
				resultDateTime: resultDateTime);
		}
	}
}