using System;
using MongoDB.Driver;

namespace PragProgPres.Data
{
	public class MongoConnectionHandler<T> where T : IMongoEntity
	{
		public MongoCollection<T> MongoCollection { get; private set; }

		public MongoConnectionHandler()
		{
			const string connectionString = "mongodb://localhost";

			var mongoClient = new MongoClient(connectionString);

			var mongoServer = mongoClient.GetServer();

			const string databaseName = "PragProgPres";
			var db = mongoServer.GetDatabase(databaseName);

			MongoCollection = db.GetCollection<T>(typeof(T).Name.ToLower() + "s");
		}
	}
}

