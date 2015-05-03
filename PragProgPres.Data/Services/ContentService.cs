using System;
using System.Collections.Generic;
using PragProgPres.Data.Entities;
using MongoDB.Driver.Builders;
using MongoDB.Driver;

namespace PragProgPres.Data
{
	public class ContentService: EntityService<Content>
	{
		public IEnumerable<Content> GetContentDetails(int limit, int skip)
		{
			var contentCursor = this.MongoConnectionHandler.MongoCollection.FindAllAs<Content>()
				.SetSortOrder(SortBy<Content>.Descending(g => g.DateCreated))
				.SetLimit(limit)
				.SetSkip(skip)
				.SetFields(Fields<Content>.Include(g => g.Id, g => g.Body, g => g.DateCreated, g=> g.Title, g=> g.Order));
			return contentCursor;
		}


		public override void Update(Content entity)
		{
			var updateResult = this.MongoConnectionHandler.MongoCollection.Update(
				Query<Content>.EQ(p => p.Id, entity.Id),
				Update<Content>.Set(p => p.Body, entity.Body)
				.Set(p => p.Body, entity.Body)
				.Set(p => p.Title, entity.Title),
				new MongoUpdateOptions
				{
					WriteConcern = WriteConcern.Acknowledged
				});

			if (updateResult.DocumentsAffected == 0)
			{
				//// Something went wrong

			}
		}
	}
}

