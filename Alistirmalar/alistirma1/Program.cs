using System;

namespace alistirma1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//kullanıcıdan gelen sayısal değere
			//göre ekrana 1 eksiltere 0 değerine
			//ulaşıncaya kadar ekrana yazdır
			Console.WriteLine("Lütfen 1 değer giriniz");
			int deger = Convert.ToInt32(Console.ReadLine());
			Console.Clear();

			while (deger != 0) //değer 0a eşit değilse
			{
				Console.WriteLine(deger);
				deger--; //değeri 1 azalt
			}
			Console.WriteLine("İşlem tamamlandı");
		}
	}
}
