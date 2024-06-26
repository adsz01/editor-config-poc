using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Validation
{
	public class ValidationErrorDetails : ICommunityCorrelationResponse
	{
		public ICorrelationResponse CorrelationResponse { get; }
		public IEnumerable<ValidationError> Errors { get; }

		[JsonConstructor]
		private ValidationErrorDetails(ICorrelationResponse correlationResponse, IEnumerable<ValidationError> errors)
		{
			CorrelationResponse = correlationResponse;
			Errors = errors;
		}

		public static ValidationErrorDetails Create(ICorrelationResponse correlationResponse, IEnumerable<ValidationError> errors) =>
			new ValidationErrorDetails(correlationResponse, errors);
	}
}
