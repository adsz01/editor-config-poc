using Newtonsoft.Json;
using SB.Community.Correlation.Interfaces;
using SB.Customer.Management.Contracts.Common;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.Customer
{
	public class GetCustomerLimitsAndClassificationResponse : ICustomerResponse
	{
		public IEnumerable<CustomerLimitAndClassification> CustomerLimits { get; }

		public IEnumerable<FailedCustomer> FailedCustomers { get; }

		public ICorrelationResponse CorrelationResponse { get; }

		public CustomerResponseCode ResponseCode { get; }

		public IEnumerable<string> ResponseNotes { get; }

		[JsonConstructor]
		public GetCustomerLimitsAndClassificationResponse(IEnumerable<CustomerLimitAndClassification> customerLimits, IEnumerable<FailedCustomer> failedCustomers, ICorrelationResponse correlationResponse, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			CustomerLimits = customerLimits;
			CorrelationResponse = correlationResponse;
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
			FailedCustomers = failedCustomers;
		}

		public static GetCustomerLimitsAndClassificationResponse Create(IEnumerable<CustomerLimitAndClassification> customerLimits, IEnumerable<FailedCustomer> failedCustomers, ICorrelationResponse correlationResponse, CustomerResponseCode responseCode, IEnumerable<string> responseNotes)
		{
			return new GetCustomerLimitsAndClassificationResponse(customerLimits, failedCustomers, correlationResponse, responseCode, responseNotes);
		}
	}
}
