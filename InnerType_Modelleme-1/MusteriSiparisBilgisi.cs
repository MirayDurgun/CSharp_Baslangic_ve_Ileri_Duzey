using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType_Modelleme
{
	public class MusteriSiparisBilgisi
	{
		public string siparisNumarasi { get; set; }


		//Inner Type metotlara erişme ve kullanma tüm classlara yapılacak
		public void musteriSiparisTestMetot()
		{
			Console.WriteLine("Müşteri sipariş test metot");
		}

		public Urun[] urunListe;
		public MusteriSiparisBilgisi()
		{
			urunListe = new Urun[5];
		}
	}
}
