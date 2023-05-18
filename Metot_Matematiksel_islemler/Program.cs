using System;

namespace Metot_Matematiksel_islemler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hesap Makinesi");
			Matematik matematik = new Matematik();
		Yenidenislemyap:
			matematik.menu();

			string secim = Console.ReadLine();

			Console.WriteLine("1. Değeri giriniz");
			decimal deger1 = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine("2. Değeri giriniz");
			decimal deger2 = Convert.ToDecimal(Console.ReadLine());
			decimal sonuc = 0;

			switch (secim)
			{
				case "+":
					sonuc = matematik.Toplamaİslemi(deger1, deger2);//sayi1 ve sayi2'ye atar
					matematik.sonucEkranaYaz(deger1, deger2, sonuc, "+");
					break;
				case "-":
					sonuc = matematik.Cikarmaİslemi(deger1, deger2);
					matematik.sonucEkranaYaz(deger1, deger2, sonuc, "-");
					break;
				case "*":
					sonuc = matematik.Carpmaİslemi(deger1, deger2);
					matematik.sonucEkranaYaz(deger1, deger2, sonuc, "*");
					break;
				case "/":
					sonuc = matematik.Bolmeİslemi(deger1, deger2);
					matematik.sonucEkranaYaz(deger1, deger2, sonuc, "/");
					break;
				default:
					Console.WriteLine("Girmiş olduğunuz değer menü içinde bulunamadı \n Yeniden deneyiniz");
					System.Threading.Thread.Sleep(1000);
					goto Yenidenislemyap;
			}
			Console.WriteLine("Yeniden işlem yapmak istiyor musunuz? \n Evet & Hayır");
			string EH = Console.ReadLine();
			if (EH.ToUpper() == "E")
			{
				goto Yenidenislemyap;
			}
		}
	}
}
