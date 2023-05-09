using System;

namespace Break_Continue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//sonsuz döngü
			/*	for(; ; )
				{
					Console.WriteLine("sonsuz döngü");
				}*/

			//break anahtar kelimesi = şart sağlandığında kırmak için kullanılır

			int sayac = 0;
			for (; ; )
			{
				sayac++;
				Console.WriteLine("sonsuz döngü");
				if (sayac == 2)

					break; //sayac 2ye eşitse döngüyü kır

				else //değilse sayacı yazdır
					Console.WriteLine(sayac);

			}
		}
	}
}
