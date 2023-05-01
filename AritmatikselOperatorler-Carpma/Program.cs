using System;

namespace AritmatikselOperatorler_Carpma
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// *
			// byte  int double float decimal 

			double d1 = 10.4;
			double d2 = 10.6;
			double sonuc = d1 * d2;

            Console.WriteLine(sonuc);

			//uzun hali
            double sonucDouble = d1 * d2;
			int sonucInt = (int)sonucDouble;

			//kısa hali
			//d1*d2 den gelen ondalıklı sayısı int ondalıksız yazdırır 110
			sonucInt = (int)(d1 * d2);

			Console.WriteLine(sonucInt);
		}
	}
}
