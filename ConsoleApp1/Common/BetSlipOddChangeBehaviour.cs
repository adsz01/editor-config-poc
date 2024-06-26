namespace SB.Customer.Management.Contracts.Common
{
	public enum BetSlipOddChangeBehaviour
	{
		CanAcceptOddChanges = 1,
		MustRemoveSelectionFromBetSlip = 2,
		CanAcceptHigherOddChanges = 3
	}
}
