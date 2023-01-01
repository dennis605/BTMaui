using System;
namespace BTMaui.Models
{
	public class VeranstaltungTagesplan
	{
		public int IdVeranstaltungTagesplan { get; set; }

		public IEnumerable<Tagesplan> Tagesplans { get; set; }
		public IEnumerable<Veranstaltung> Veranstaltungs { get; set; }

	}
}

