using System;

namespace Convert_Parse
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string ifadeyi int e dönüştürme
			string metin1 = "100";

			//2sinden biri kullanılabilir
			int s1= int.Parse(metin1);
			int s2= Convert.ToInt32(metin1);

			//string ifadeyi boola dönüştürme
			string metin2 = "true";
			bool b1=bool.Parse(metin2);
			bool b2=Convert.ToBoolean(metin2);
		
			//Convert ve Parse arasındaki fark nedir?
			/*
			 *parse null değer alırken hata verir
			 *convert hata vermez devam ettirir ama değeri 0 yapar
			 **/
		}
	}
}
