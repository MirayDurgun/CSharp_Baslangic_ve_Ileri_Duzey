using System;

namespace Bilincli
{
	internal class Program
	{
		static void Main(string[] args)
		{
			byte sayi1 = 255;
			// 0 ile 255 arasında değer alabilirdi

			int sayi2 = 256;

			//bilinçli tür dönüşümü
			int sayi3 = sayi1;
			/*
			 * byte int değerine gönderdik
			 * byte değer aralığını int karşıladığı için
			 * içindeki değeri hatasız aktarır
			*/
		}
	}
}
