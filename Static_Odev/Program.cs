using System;

namespace Static_Odev
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//140. video ödev açıklaması

			Musteri m1 = new Musteri();
			m1.musteriID = 1;
			m1.isim = "Miray";
			m1.soyisim = "Durgun";
			m1.emailadres = "Miray@gmail.com";
			m1.KullaniciAd = "Miraay";
			m1.sifre = "123456";

			Musteri.MusteriEkler(m1);


			//hızlı tip tanımı
			//space basıldığında nesnenin public fieldleri gelir
			Musteri m2 = new Musteri()
			{
				musteriID = 2,
				isim = "can",
				soyisim = "Durgun",
				emailadres = "melih@gmail.com",
				KullaniciAd = "melih.drgn",
				sifre = "123456"
			};

			Musteri m3 = new Musteri()
			{
				musteriID = 3,
				isim = "can",
				soyisim = "Durgun",
				emailadres = "can@gmail.com",
				KullaniciAd = "can.drgn",
				sifre = "123456"
			};

		}
	}
}
