using System;
namespace BTMaui.Models
{
	public class Veranstaltung
	{
		public int IdVeranstaltung { get; set; }

		public DateTime Tagesplandatum { get; set; }

		public String NameVeranstaltung { get; set; }

		public DateTime DatumVeranstaltung { get; set; }

		public DateTime AnfangVeranstaltung { get; set; }

		public DateTime EndeVeranstaltung { get; set; }

		public String txtVeranstaltung { get; set; }

		public Ort OrtVeranstaltungperty { get; set; }
	}
}

