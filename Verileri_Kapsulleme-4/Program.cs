using System;

namespace Verileri_Kapsulleme_4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//	field değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde  bizim belirlediğimiz
			//bir süreçten geçsin veri daha sonra gösterilsin

			Musteri m1 = new Musteri();
			m1.isim = "Miray";
			m1.Soyisim = "durgun";
			Console.WriteLine(m1.EMail);
		}
	}
}
