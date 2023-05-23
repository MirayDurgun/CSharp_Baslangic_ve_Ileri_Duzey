using System;

namespace Verileri_Kapsulleme_Odev_1
{
	internal class Program
	{
		//Ornek 2 Field Değer ataması yapılsın ama değer okunamasın
		static void Main(string[] args)
		{
			Musteri m1 = new Musteri();
			m1.ad = "Miray";
			m1.soyad = "Durgun";
			m1.TcKimlikNo = "12345678910";

			string TC = m1.TcKimlikNo; // ilk 3 hanesini gösterir
		}
	}
}
