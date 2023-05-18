using System;
using MetotOdev1;

namespace Public_ErisimBelirleyicisi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Ödev üzerinden public private kullanma

			string OgrenciAd = string.Empty; // içi boş olacak
			string OgrenciSoyad = string.Empty; // içi boş olacak

			Console.WriteLine("Not ortalaması hesaplamaya hoş geldiniz");
			Console.WriteLine("Önce öğrenci bilgilerini giriniz");
			Console.Write("Adınız : ");
			OgrenciAd = Console.ReadLine();
			Console.Write("Soyadınız : ");
			OgrenciSoyad = Console.ReadLine();
			Console.WriteLine("1. Notunuzu giriniz");
			decimal not1 = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine("2. Notunuzu giriniz");
			decimal not2 = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine("3. Notunuzu giriniz");
			decimal not3 = Convert.ToDecimal(Console.ReadLine());
			Console.Clear();

			decimal ortalama =0;

			Ogrenci ogrenci = new Ogrenci();
			ogrenci.ogrenciPuanHesapla(not1, not2, not3, ortalama, OgrenciAd, OgrenciSoyad);


		}
	}
}
