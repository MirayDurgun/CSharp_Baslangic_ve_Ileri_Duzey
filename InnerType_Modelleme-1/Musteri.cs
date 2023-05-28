using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType_Modelleme
{
	public class Musteri
	{
		#region Tekil olarak kullanılan fieldler
		public int musteriID { get; set; }
		public string tcKimlikNumarasi { get; set; }
		public string isim { get; set; }
		public string soyisim { get; set; }
		public DateTime olusturmaTarihi { get; set; }
		public int kullaniciID { get; set; }
		#endregion

		#region Inner Type gerektiren Fieldler
		//müşterinin birden fazla adresi bulunabilir bunun için
		public MusteriAdres[] musteriAdresListe;
		//MusteriAdres classını çağırdık
		//müşteri nesnesinin içinde müşteri adres nesnemizi koleksiyon olarak tanımladık
		//bu sayede birden fazla müşteri adresini barındırabilecek  

		//bir müşterinin birden çok iletişim bilgisi de olabilir bunun içinde
		public MusteriIletisimBilgisi[] musteriIletisimListe;

		//bir müşterinin birden çok siparişi olabilir bunun için
		public MusteriSiparisBilgisi[] musteriSiparisListe;
		
		#endregion

		public Musteri()
		{
			musteriAdresListe = new MusteriAdres[5]; //5 elemanlı adres tanımı
			musteriIletisimListe = new MusteriIletisimBilgisi[3];
			musteriSiparisListe = new MusteriSiparisBilgisi[10];
		}

	
    }
}


