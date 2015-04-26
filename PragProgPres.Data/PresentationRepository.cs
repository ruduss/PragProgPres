using System;

namespace PragProgPres.Data
{
	public class PresentationRepository : IPresentationRepository
	{
		public PresentationRepository ()
		{
		}

		#region IPresentationRepository implementation

		public void Add ()
		{
			throw new NotImplementedException ();
		}

		public void Connect ()
		{
			var client = new MongoDB ();

		}

		#endregion
	}
}

