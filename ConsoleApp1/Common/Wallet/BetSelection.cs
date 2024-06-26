using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Common.Wallet
{
	public class BetSelection
	{
		public string EventId { get; }
		public DateTime EventStartDate { get; }
		public decimal SelectionOdds { get; }
		public FixturePhase FixturePhase { get; }
		public int MarketSelectionsCount { get; }
		public string MarketId { get; }
		public string MarketSelectionId { get; }
		public SettledState SettledState { get; }
		public IDictionary<string, string> AdditionalData { get; }

		[JsonConstructor]
		private BetSelection(string eventId, DateTime eventStartDate, decimal selectionOdds, FixturePhase fixturePhase, int marketSelectionsCount, string marketId, string marketSelectionId, SettledState settledState, IDictionary<string, string> additionalData)
		{
			EventId = eventId;
			EventStartDate = eventStartDate;
			SelectionOdds = selectionOdds;
			FixturePhase = fixturePhase;
			MarketSelectionsCount = marketSelectionsCount;
			MarketId = marketId;
			MarketSelectionId = marketSelectionId;
			SettledState = settledState;
			AdditionalData = additionalData;
		}

		public static BetSelection Create(string eventId, DateTime eventStartDate, decimal selectionOdds, FixturePhase fixturePhase, int marketSelectionsCount, string marketId, string marketSelectionId, SettledState settledState, IDictionary<string, string> additionalData) =>
			new BetSelection(eventId: eventId, eventStartDate: eventStartDate, selectionOdds: selectionOdds, fixturePhase: fixturePhase, marketSelectionsCount: marketSelectionsCount, marketId: marketId, marketSelectionId: marketSelectionId, settledState: settledState, additionalData: additionalData);
	}
}