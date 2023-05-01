using System;

namespace Alistirma_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Merhaba");
            Console.WriteLine("İsminiz nedir?");
			string isim=Console.ReadLine();
            //kullanıcının girmiş olduğu değeri bize iletir
            Console.WriteLine("Soyisminiz nedir?");
			string soyisim=Console.ReadLine();
			Console.WriteLine("Yaşadığınız şehir?");
			string sehir=Console.ReadLine();

			Console.Clear();
			//bu kod ekranı temizler

			Console.WriteLine("İsim : " + isim+ "  Soyisim : " + soyisim);
			Console.WriteLine("Şehir : " + sehir);
			Console.ReadLine();
        }
	}
}
