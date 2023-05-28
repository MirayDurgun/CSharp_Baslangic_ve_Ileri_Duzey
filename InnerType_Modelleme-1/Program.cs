using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InnerType_Modelleme;

namespace InnerType_Modelleme
{
	class Program
	{
		static void Main(string[] args)
		{
			Musteri M1 = new Musteri();

			M1.musteriID = 1;
			M1.tcKimlikNumarasi = "12345678910";
			M1.isim = "Miray";
			M1.soyisim = "Durgun";
			M1.olusturmaTarihi = DateTime.Now;


			//Inner Type
			//  M1.musteriAdresleri = new MusteriAdres[5];
			// Asla yapma, burada da yapılabilir ama yeri burası değil 
			//Classları topladığımız classta (Musteri) yapıcı metot oluşturup yazacağız bunu

			M1.musteriAdresListe[0] = new MusteriAdres() //0. indexe git new ile müşteri adresi ata 
			{
				Il = "İstanbul",
				Ilce = "K.Çekmece",
				Adres = "Adres ... ",
				adresTip = "İş Yeri"
			};

			M1.musteriAdresListe[0].musteriAdresTestMetot();

			M1.musteriSiparisListe[0] = new MusteriSiparisBilgisi()
			{
				siparisNumarasi = "siparis1"
			};

			M1.musteriSiparisListe[0].urunListe[0] = new Urun()
			{
				urunID = 1,
				urunAd = "Telefon",
				urunAdet = 500,
				urunFiyat = 1500
			};


		}
	}
}
