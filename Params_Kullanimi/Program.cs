using System;

namespace Params_Kullanimi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//params ifadesi girilen değerleri belirtmiş olduğumuz veri tipinden diziye çevirir
			//fakat bunu parametre olarak isterken bizden dizi istemez
			//belirtmiş olduğumuz veri tipinden sıralı data ister
			//istemiş olduğu sıralı datayı da dizinin içerisine otomatik olarak aktarır
			topla(5, 9, 20, 45, 80, 10, 6, 7);
		}
		static void topla(params int[] sayilar)
		{
			int toplam = 0;
			for (int i = 0; i < sayilar.Length; i++)
			{
				toplam += sayilar[i];

			}
			Console.WriteLine("Toplam = {0}", toplam);
		}
	}
}
