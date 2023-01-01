using System;
namespace BTMaui.Models
{
	public class PersonalVeranstaltung
	{

		public int IdPersonalVeranstaltung { get; set; }

		public IEnumerable<Veranstaltung> Veranstaltungs { get; set; }

		public IEnumerable<Personal> Personals { get; set; }

	}
}

