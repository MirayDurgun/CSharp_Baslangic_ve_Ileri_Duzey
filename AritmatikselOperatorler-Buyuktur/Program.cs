using System;

namespace AritmatikselOperatorler_Buyuktur
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//büyüktür için  > kullanılır
			//dönüş değeri bool olur - evet / hayır

			int b1 = 100;
			int b2 = 109;
			bool buyuk = b1 > b2;

			//küçüktür için < kullanılır
			int k1 = 190;
			int k2 = 179;
			bool kucuk = k1 < k2;

			//eşit mi için == kullanılır, = atama operatörüdür
			int e1 = 100;
			int e2 = 100;
			int e3 = 200;
			bool esit = e1 == e2;
			bool esit2 = e3 == e2;
			// != eşit değil mi demektir, olumsuzluk getirir
			bool esit3 = e1 != e2;
			bool esit4 = e3 != e2;

			//büyük eşittir >= 
			//büyük veya eşit mi?
			int be1 = 1080;
			int be2 = 10;
			bool buyukesit = be1 > be2;


			//küçük eşittir <=
			//küçük veya eşit mi?
			int ke1 = 1080;
			int ke2 = 10;
			bool kucukesit = ke1 < ke2;



		}
	}
}
