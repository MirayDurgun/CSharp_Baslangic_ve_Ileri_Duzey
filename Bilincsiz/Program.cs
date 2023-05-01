using System;

namespace Bilincsiz
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int sayi1 = 100;

			byte sayi2 = sayi1;
			//sayi1 in altı kızarık
			//int değerleri yüksek olduğundan byte sorumluluk almaz
			//fakat bu şekilde kabul etmesini sağlayabiliriz

			byte sayi3 = (byte)sayi1;
			//içindeki değeri byte çevirir
			//0 255 değer aralığını aştığında bu şekilde de hata verecektir

		}
	}
}
