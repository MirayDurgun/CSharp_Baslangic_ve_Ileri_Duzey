using System;

namespace ref_ve_out
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ref ve out işlevleri aynıdır

			int sayi1 = 0;
			degerAta(ref sayi1); //metoda ref anahtar kelimesiyle değeri aktarır
								 //sayi1 değeri 10 değerini alır

			int sayi2 = 0;
			degerAta2(out sayi2);
		}
		static void degerAta(ref int gelenDeger)
		{
			gelenDeger = 10;
		}
		static void degerAta2(out int gelenDeger2)
		{
			gelenDeger2 = 10;
		}
	}

}

