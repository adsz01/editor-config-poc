namespace SB.Customer.Management.Contracts.Input.Customer
{
	public enum CreateBetSlipOddChangeBehaviour
	{
		Default = 0,
		CanAcceptOddChanges = 1,
		MustRemoveSelectionFromBetSlip = 2,
		CanAcceptHigherOddChanges = 3
	}
}
