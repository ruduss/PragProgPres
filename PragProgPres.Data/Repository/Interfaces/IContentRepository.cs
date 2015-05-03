using PragProgPres.Data.Entities;
using System.Collections.Generic;
using System;

namespace PragProgPres.Data.Repository.Interfaces
{
	public interface IContentRepository : IDisposable 
	{
		IEnumerable<Content> GetContent();
		Content GetContentById(int contentId);
		void InsertContent(Content content);
		void DeleteContent(int contentId);
		void UpdateContent();
		void Save();
	}
}

