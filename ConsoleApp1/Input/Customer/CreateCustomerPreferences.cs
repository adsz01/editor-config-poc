using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Input.Customer
{
	public class CreateCustomerPreferences
	{
		public CreateBetSlipOddChangeBehaviour CreateBetSlipOddChangeBehaviour { get; }
		public CreateOddFormatTypes CreateOddFormatType { get; }

		[JsonConstructor]
		private CreateCustomerPreferences(CreateBetSlipOddChangeBehaviour createBetSlipOddChangeBehaviour, CreateOddFormatTypes createOddFormatType)
		{
			CreateBetSlipOddChangeBehaviour = createBetSlipOddChangeBehaviour;
			CreateOddFormatType = createOddFormatType;
		}

		public static CreateCustomerPreferences Create(CreateBetSlipOddChangeBehaviour createBetSlipOddChangeBehaviour, CreateOddFormatTypes createOddFormatType)
		{
			return new CreateCustomerPreferences(createBetSlipOddChangeBehaviour, createOddFormatType);
		}
	}
}