using System;

namespace Alistirma2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Toplama için 1");
			Console.WriteLine("Çıkartma için 2");
			Console.WriteLine("Bölme için 3");
			Console.WriteLine("Çarpma için 4");
			Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
			string secim = Console.ReadLine();

			Console.Clear();

			Console.Write("1. sayı giriniz : ");
			double s1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("2. sayı giriniz : ");
			double s2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("\n");

			double sonuc;
			if (secim == "1")
			{
				sonuc = s1 + s2;
				Console.WriteLine(sonuc);
			}
			else if (secim == "2")
			{
				sonuc = s1 - s2;
				Console.WriteLine(sonuc);
			}
			else if (secim == "3")
			{
				if (s2 == 0)
				{
					Console.WriteLine("Bölen değer 0 olamaz");
				}
				else
				{
					sonuc = s1 / s2;
					Console.WriteLine(sonuc);
				}
			}
			else if (secim == "4")
			{
				sonuc = s1 * s2;
				Console.WriteLine(sonuc);
			}
			else
			{
				Console.WriteLine("hatalı seçim yaptınız");
			}

		}
	}
}
