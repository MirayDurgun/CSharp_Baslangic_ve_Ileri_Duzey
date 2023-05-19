using System;

namespace siniflar
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Musteri m1 = new Musteri();
			//m1 sistem içerisinde çağıracağım isim
			//new ile sistemde bu nesnenin bir örneğini oluştururuz
			m1.isim = "Miray";
			m1.soyisim = "Durgun";
			Musteri m2 = m1;
			//m1 deki değerleri m2 alır

			m2.isim = "Melih"; //m2 üzerinden ismi değiştirince m1de de değişmiş olur

		}
	}
}
