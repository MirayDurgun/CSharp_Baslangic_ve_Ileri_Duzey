using System;

namespace OOP_Siniflar_Odev
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Arac a1 = new Arac("Opel", "Corsa", 2020, 100);
			a1.AlisFiyat = 560000;
			a1.SatisFiyat = 700000;
			a1.MaxİndTutar = 2000;
			//a1.Fiyat = kapsülleme konusunda aynı örnek yapılacak fiyat kısmı orda anlatılacak

			a1.FiyatAta(3000000);
			a1.BilgileriGoruntule();
		}
	}
}
