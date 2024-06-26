using SB.Community.Correlation.Interfaces;

namespace SB.Customer.Management.Contracts.Output
{
	public sealed class ApiResultDto : ICommunityCorrelationResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }

		private ApiResultDto(ICorrelationResponse correlationResponse)
		{
			CorrelationResponse = correlationResponse;
		}

		public static ApiResultDto Create(ICorrelationResponse correlationResponse)
		{
			var dto = new ApiResultDto(correlationResponse);

			return dto;
		}
	}
}