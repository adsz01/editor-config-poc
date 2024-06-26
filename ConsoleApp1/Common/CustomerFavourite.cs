using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SB.Customer.Management.Contracts.Common
{
	public sealed class CustomerFavourite
	{
		public Guid FavouriteId { get; }

		public FavouriteEntityType EntityType { get; }

		public IDictionary<FavouriteEntityType, string> Context { get; }

		public string Value { get; }

		[JsonConstructor]
		private CustomerFavourite(Guid favouriteId, FavouriteEntityType entityType, string value, IDictionary<FavouriteEntityType, string> context)
		{
			FavouriteId = favouriteId;
			EntityType = entityType;
			Value = value;
			Context = context;
		}

		public static CustomerFavourite Create(Guid favouriteId, FavouriteEntityType entityType, string value, IDictionary<FavouriteEntityType, string> context)
		{
			return new CustomerFavourite(favouriteId, entityType, value, context);
		}
	}
}
