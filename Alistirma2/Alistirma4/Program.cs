using System;

namespace Alistirma4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Kullanıcı adınız");
			string kAd = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Şifre giriniz");
			int sifre = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Kontroller sağlanıyor...");


			string kullaniciAdi = "Miray Durgun";
			//bool esit = kAd == "Miray Durgun";
			//şeklinde de tanımlanabilir

			bool esit = kAd == kullaniciAdi;
			bool esitDegil = kAd != kullaniciAdi;
			Console.WriteLine("Kullanıcı adı uyuyor mu? " + esit);
			Console.WriteLine("Kullanıcı adı uymuyor mu? " + esitDegil);

			int parola = 123;
			bool uyum = sifre == parola;
			bool uyumsuz = sifre != parola;
			Console.WriteLine("Şifre eşleşiyor mu? " + uyum);
			Console.WriteLine("Şifre eşleşmiyor mu? " + uyumsuz);


		}
	}
}
