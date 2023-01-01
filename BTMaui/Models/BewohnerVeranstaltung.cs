using System;
namespace BTMaui.Models
{
	public class BewohnerVeranstaltung
	{


			public int IdBewohnerVeranstaltung { get; set; }
		public IEnumerable <Veranstaltung> Veranstaltungs { get; set; }
		public IEnumerable <Bewohner> Bewohners { get; set; }

	}
}

