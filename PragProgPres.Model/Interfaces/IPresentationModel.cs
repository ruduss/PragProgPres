using System;
using System.Collections.Generic;

namespace PragProgPres.Model.Interfaces
{
	public interface IPresentationModel
	{
		IPresentation GetPresentationById(int id);
		IList<IPresentation> GetAllPresentations();

	}
}

