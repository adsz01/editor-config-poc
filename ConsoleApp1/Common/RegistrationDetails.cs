using Newtonsoft.Json;
using System;

namespace SB.Customer.Management.Contracts.Common
{
	public class RegistrationDetails
	{
		public string RegisteredIPAddress { get; }
		public DateTime RegistrationDate { get; }

		[JsonConstructor]
		private RegistrationDetails(string registeredIPAddress, DateTime registrationDate)
		{
			RegisteredIPAddress = registeredIPAddress;
			RegistrationDate = registrationDate;
		}

		public static RegistrationDetails Create(string registeredIPAddress, DateTime registrationDate)
		{
			return new RegistrationDetails(registeredIPAddress, registrationDate);
		}

	}
}
