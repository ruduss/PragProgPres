using System;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using PragProgPres.Data.Entities;

namespace PragProgPres.Data
{
	public abstract class EntityService<T> : IEntityService<T> where T : IMongoEntity
	{
		protected readonly MongoConnectionHandler<T> MongoConnectionHandler;

		public virtual void Create(T entity)
		{
			var result = this.MongoConnectionHandler.MongoCollection.Save(
				entity, 
				new MongoInsertOptions
				{
					WriteConcern = WriteConcern.Acknowledged
				});

			if (!result.Ok)
			{
				//// Something went wrong
			}
		}

		public virtual void Delete(string id)
		{
			var result = this.MongoConnectionHandler.MongoCollection.Remove(
				Query<T>.EQ(e => e.Id, 
					new ObjectId(id)), 
				RemoveFlags.None, WriteConcern.Acknowledged);            

			if (!result.Ok)
			{
				//// Something went wrong
			}
		}

		protected EntityService()
		{
			MongoConnectionHandler = new MongoConnectionHandler<T>();
		}

		public virtual T GetById(string id)
		{
			var entityQuery = Query<T>.EQ(e => e.Id, new ObjectId(id));
			return this.MongoConnectionHandler.MongoCollection.FindOne(entityQuery);
		}

		public abstract void Update(T entity);
	}
}