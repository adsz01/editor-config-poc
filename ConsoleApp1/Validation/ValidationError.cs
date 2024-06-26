using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Validation
{
	public class ValidationError
	{
		public ErrorCode Code { get; }

		public string Description { get; }

		[JsonConstructor]
		private ValidationError(ErrorCode code, string description)
		{
			Code = code;
			Description = description;
		}

		public static ValidationError Create(ErrorCode code, string description) =>
			new ValidationError(code, description);
	}
}