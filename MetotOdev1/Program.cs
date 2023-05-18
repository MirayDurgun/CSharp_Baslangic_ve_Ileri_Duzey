using System;

namespace MetotOdev1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*öğrenci adı soyadı al
			 3 farklı ders notu al
			bu bilgileri öğrenci sınıfında 
			öğrenci puan hesapla adlı metota parametre olarak verip
			bilgisini ekrana yazdır
			ortlama sonucu 45ten büyük ise geçti
			küçük ise kaldı desin*/

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

			decimal ortalama = 0;

			Ogrenci ogrenci = new Ogrenci();
			ogrenci.ogrenciPuanHesapla(not1, not2, not3, ortalama, OgrenciAd, OgrenciSoyad);
		}
	}
}
