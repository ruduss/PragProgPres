using System;
using PragProgPres.Data.Entities;
using PragProgPres.Data.Repository.Interfaces;
using System.Collections.Generic;
using PragProgPres.Data.Entities;

namespace PragProgPres.Data
{
	public class ContentRepository : IContentRepository, IDisposable 
	{
		private ContentContext context;

		#region Constructor
		public ContentRepository(ContentContext context)
		{
			this.context = context;
		}

		#endregion

		#region IContentRepository implementation

		public IEnumerable<Content> GetContent ()
		{
			return context.Content.ToList ();
		}

		public Content GetContentById (int id)
		{
			return context.Content.Find (id);
		}

		public void InsertContent (Content content)
		{
			context.Content.Add (content);
		}

		public void DeleteContent (int contentId)
		{
			Content content = context.Content.Find (contentId);
			context.Content.Remove (content);
		}

		public void UpdateContent (Content content)
		{
			context.Entry (content).State = EntityState.Modified;
		}

		public void Save ()
		{
			Content.SaveChanges ();
		}

		#endregion

		#region IDisposable implementation

		public void Dispose ()
		{
			throw new NotImplementedException ();
		}

		#endregion




	}
}

