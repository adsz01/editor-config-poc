using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Common
{
	public class OddsFormat
	{
		public OddsFormatType OddsFormatType { get; }
		public OriginOfValue OriginOfValue { get; }

		[JsonConstructor]
		private OddsFormat(OddsFormatType oddsFormatType, OriginOfValue originOfValue)
		{
			OddsFormatType = oddsFormatType;
			OriginOfValue = originOfValue;
		}

		public static OddsFormat Create(OddsFormatType oddsFormatType, OriginOfValue originOfValue)
		{
			return new OddsFormat(oddsFormatType, originOfValue);
		}
	}
}