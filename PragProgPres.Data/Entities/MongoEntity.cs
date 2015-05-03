using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PragProgPres.Data
{
	public class MongoEntity: IMongoEntity
	{
		[BsonId]
		public ObjectId Id { get; set; }
	}
}

