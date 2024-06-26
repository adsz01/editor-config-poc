using SB.Community.Correlation.Interfaces;

namespace SB.Customer.Management.Contracts.Output
{
	public sealed class ApiErrorDto : ICommunityCorrelationResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public string Reason { get; }

		private ApiErrorDto(ICorrelationResponse correlationResponse, string reason)
		{
			CorrelationResponse = correlationResponse;
			Reason = reason;
		}

		public static ApiErrorDto Create<TCorrelationResponse>(TCorrelationResponse correlationResponse, string reason)
			where TCorrelationResponse : ICorrelationResponse
		{
			var dto = new ApiErrorDto(correlationResponse, reason);

			return dto;
		}
	}
}