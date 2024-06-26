using Newtonsoft.Json;
using System;

namespace SB.Customer.Management.Contracts.Output.Transaction.Common
{
	public class Fee
	{
		public Guid Id { get; }
		public decimal Amount { get; }
		public string CurrencyCode { get; }
		public FeeType FeeType { get; }

		[JsonConstructor]
		private Fee(Guid id, decimal amount, string currencyCode, FeeType feeType)
		{
			Id = id;
			Amount = amount;
			CurrencyCode = currencyCode;
			FeeType = feeType;
		}

		public static Fee Create(Guid id, decimal amount, string currencyCode, FeeType feeType)
		{
			return new Fee(
				id: id,
				amount: amount,
				currencyCode: currencyCode,
				feeType: feeType);
		}

		public ResultCode Validate()
		{
			if (Amount <= 0)
				return ResultCode.FeeCannotBeLessThanOrEqualToZero;

			return string.IsNullOrEmpty(CurrencyCode)
					? ResultCode.CurrencyCodeIsRequired
					: ResultCode.Success;
		}
	}
}