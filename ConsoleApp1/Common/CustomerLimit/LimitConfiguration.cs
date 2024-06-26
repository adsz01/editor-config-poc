using Newtonsoft.Json;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Common
{
	public class LimitConfiguration
	{
		public long? Id { get; }

		public IEnumerable<LimitCriteria> LimitCriterias { get; }

		public decimal Multiplier { get; }

		[JsonConstructor]
		private LimitConfiguration(long? id, IEnumerable<LimitCriteria> limitCriterias, decimal multiplier)
		{
			Id = id;
			LimitCriterias = limitCriterias;
			Multiplier = multiplier;
		}

		public static LimitConfiguration Create(long? id, IEnumerable<LimitCriteria> limitCriterias, decimal multiplier)
		{
			return new LimitConfiguration(id, limitCriterias, multiplier);
		}
	}
}
