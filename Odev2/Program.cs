using System;

namespace Odev2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//not ortalaması
			/*
			 * 
			 * 45ten küçükse kaldı
			 * 45e eşitse veya 70ten küçükse orta
			 * 70 90 arası ise iyi
			 * 90 100 ise başarılı
			 */
			int not1, not2, not3;
            Console.WriteLine("Lütfen 1. notunuzu giriniz");
			not1=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Lütfen 2. notunuzu giriniz");
			not2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Lütfen 3. notunuzu giriniz");
			not3 = Convert.ToInt32(Console.ReadLine());
			Console.Clear();
			Console.WriteLine("Notlarınız şu şekildedir:");
			Console.WriteLine("1. not" + not1);
			Console.WriteLine("2. not" + not2);
			Console.WriteLine("3. not" + not3);
			Console.WriteLine("ortalamanız hesaplanıyor");

			int sonuc = (not1 + not2 + not3) / 3;
			if (sonuc < 45)
			{

				Console.WriteLine("Kaldınız, " + sonuc);
			}
			else if (sonuc == 45 && sonuc < 70)
			{
				Console.WriteLine("Orta, " + sonuc);
			}
			else if (sonuc == 70 && sonuc < 90)
			{
				Console.WriteLine("İyi, " + sonuc);
			}
			else if (sonuc == 90 && sonuc <= 100)
			{
				Console.WriteLine("Başarılı tebrikler, " + sonuc);
			}
			else
			{
				Console.WriteLine("notlarınızı kontrol ediniz");
			}





		}
	}
}
