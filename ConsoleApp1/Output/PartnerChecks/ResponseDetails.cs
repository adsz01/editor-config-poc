using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Output.Wallet;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Output.PartnerChecks
{
	public class ResponseDetails
	{
		public WalletResponseCode ResponseCode { get; }
		public IEnumerable<string> ResponseNotes { get; }
		public IDictionary<string, string> AdditionalData { get; }

		[JsonConstructor]
		private ResponseDetails(WalletResponseCode responseCode, IEnumerable<string> responseNotes, IDictionary<string, string> additionalData)
		{
			ResponseCode = responseCode;
			ResponseNotes = responseNotes;
			AdditionalData = additionalData;
		}

		public static ResponseDetails Create(WalletResponseCode responseCode, IEnumerable<string> responseNotes, IDictionary<string, string> additionalData)
		{
			return new ResponseDetails(responseCode, responseNotes, additionalData);
		}
	}
}
