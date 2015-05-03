using System;
using MongoDB.Bson.Serialization.Attributes;

namespace PragProgPres.Data.Entities
{
	public class Content : IMongoEntity
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
		public int Order { get; set; }
		[BsonDateTimeOptions(DateOnly = true)]
		public DateTime DateCreated { get; set; }

	}
}

