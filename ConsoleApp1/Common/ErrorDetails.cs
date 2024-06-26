using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Common
{
	public class ErrorDetails
	{
		public string ErrorDescription { get; }

		[JsonConstructor]
		private ErrorDetails(string errorDescription)
		{
			ErrorDescription = errorDescription;
		}

		public static ErrorDetails Create(string errorDescription)
		{
			return new ErrorDetails(errorDescription);
		}
	}
}
