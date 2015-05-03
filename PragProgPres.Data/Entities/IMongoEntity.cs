using System;
using MongoDB.Bson;

namespace PragProgPres.Data
{
	public interface IMongoEntity
	{
		ObjectId Id { get; set; }

	}
}

