using Newtonsoft.Json;

namespace SB.Customer.Management.Contracts.Common
{
	public class LimitCriteria
	{
		public long? Id { get; }

		public string EntityId { get; }

		public EntityType EntityType { get; }

		[JsonConstructor]
		private LimitCriteria(long? id, string entityId, EntityType entityType)
		{
			Id = id;
			EntityId = entityId;
			EntityType = entityType;
		}

		public static LimitCriteria Create(long? id, string entityId, EntityType entityType)
		{
			return new LimitCriteria(id, entityId, entityType);
		}
	}
}
