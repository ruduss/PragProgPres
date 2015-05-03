using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PragProgPres.Data.Entities;
using PragProgPres.Data;

namespace PragProgPres.Controllers
{
    public class ContentController : Controller
    {
        public ActionResult Index()
        {
			var contentService = new ContentService ();
			var contentDetails = contentService.GetContentDetails (100, 0);
			return View ();
        }

		public ActionResult Create()
		{
			return View (new Content());
		}

		[HttpPost]
		public ActionResult Create(Content content)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var contentService = new ContentService();
					contentService.Create(content);
					return RedirectToAction("Index");
				}

				return View(content);
			}
			catch
			{
				return View(content);
			}
		}

		public ActionResult Edit(string id)
		{
			var contentService = new ContentService ();
			var content = contentService.GetById (id);
			return View (content);
		}

		[HttpPost]
		public ActionResult Edit(Content content)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var contentService = new ContentService();
					contentService.Update(content);
					return RedirectToAction("Index");
				}

				return View(content);
			}
			catch
			{
				return View(content);
			}
		}
    }
}