using System;
namespace BTMaui.Models
{
	public class Tagesplan
	{
		public int IdTagesplan { get; set; }

		public String NameTagesplan { get; set; }

		public DateTime DatumTagesplan { get; set; }

		public IEnumerable<Veranstaltung> Veranstaltungs { get; set; }

	}
}

