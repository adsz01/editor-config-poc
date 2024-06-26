using Newtonsoft.Json;
using SB.Customer.Management.Contracts.Common;
using System;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class UpdatePersonalInformation
	{
		public PropertyValue<string> FirstName { get; }
		public PropertyValue<string> LastName { get; }
		public PropertyValue<string> Email { get; }
		public PropertyValue<string> Mobile { get; }
		public Address Address { get; }
		public DateTime? DateOfBirth { get; }
		public Gender? Gender { get; }
		public string EmailHash { get; }

		[JsonConstructor]
		private UpdatePersonalInformation(PropertyValue<string> firstName, PropertyValue<string> lastName,
			PropertyValue<string> email, PropertyValue<string> mobile, Address address, DateTime? dateOfBirth, Gender? gender, string emailHash)
		{
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Mobile = mobile;
			Address = address;
			DateOfBirth = dateOfBirth;
			Gender = gender;
			EmailHash = emailHash;
		}


		public static UpdatePersonalInformation Create(PropertyValue<string> firstName, PropertyValue<string> lastName,
			PropertyValue<string> email, PropertyValue<string> mobile, Address address, DateTime? dateOfBirth, Gender? gender, string emailHash)
		{
			return new UpdatePersonalInformation(firstName, lastName, email, mobile, address, dateOfBirth, gender, emailHash);
		}
	}
}