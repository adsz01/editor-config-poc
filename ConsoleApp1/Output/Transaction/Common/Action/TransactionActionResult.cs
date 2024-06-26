using Newtonsoft.Json;
using System;

namespace SB.Customer.Management.Contracts.Output.Transaction.Common.Action
{
	public class TransactionActionResult
	{
		public Guid Id { get; }
		public Guid TransactionActionId { get; }
		public string PartnerTransactionReference { get; }
		public ResultCode ResultCode { get; }
		public string ResultNotes { get; }
		public Guid SportsbookWalletTransactionId { get; }
		public DateTime ResultDateTime { get; }

		[JsonConstructor]
		private TransactionActionResult(
			Guid id,
			Guid transactionActionId,
			string partnerTransactionReference,
			ResultCode resultCode,
			string resultNotes,
			Guid sportsbookWalletTransactionId,
			DateTime resultDateTime)
		{
			Id = id;
			TransactionActionId = transactionActionId;
			PartnerTransactionReference = partnerTransactionReference;
			ResultCode = resultCode;
			ResultNotes = resultNotes;
			SportsbookWalletTransactionId = sportsbookWalletTransactionId;
			ResultDateTime = resultDateTime;
		}

		public static TransactionActionResult Create(
			Guid id,
			Guid transactionActionId,
			string partnerTransactionReference,
			ResultCode resultCode,
			string resultNotes,
			Guid sportsbookWalletTransactionId,
			DateTime resultDateTime)
		{
			return new TransactionActionResult(
				id: id,
				transactionActionId: transactionActionId,
				partnerTransactionReference: partnerTransactionReference,
				resultCode: resultCode,
				resultNotes: resultNotes,
				sportsbookWalletTransactionId: sportsbookWalletTransactionId,
				resultDateTime: resultDateTime);
		}
	}
}