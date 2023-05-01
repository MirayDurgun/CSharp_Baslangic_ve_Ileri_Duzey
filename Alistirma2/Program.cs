using System;

namespace Alistirma2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//soru 1 = string olarak verilen değeri bool tipine dönüştür
			string metin1 = "true";
			bool b1=Convert.ToBoolean(metin1);
			bool b11=bool.Parse(metin1);

			//soru 2 = int içerisinde olan 100 değerini byte ve float değişken tiprlerini dönüştürün
			int s1 = 100;
			byte byt1 = (byte)s1;

			float f1 = s1;

			//soru 3 = Byte değiken içerisinde olan tipi Decimal değişken tipine dönüştürün
			byte byt2 = 10;
			decimal d1 = byt2;

		}
	}
}
