using System;

namespace Alistirma2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*kullanıcıdan gelen değerlerin
			 * toplamını ekrana yazdır
			 * 0dan küçük değer girişi yapılırsa toplama 
			 * işlemi bitsin ve ekrana toplam sonuc yazsın
			 */
			Console.WriteLine("Toplamak istediğiniz sayıları girinir");
			Console.WriteLine("-1 değeri işlemi durdurur");
			int sayi = 0, toplam = 0;
			while (true) //sonsuz kere kullanıcıya sorar
			{
				sayi = Convert.ToInt32(Console.ReadLine());

				if (sayi < 0)
					break;
				else
					toplam += sayi;

			}
			Console.WriteLine("Toplam değer = " + toplam);



		}
	}
}
