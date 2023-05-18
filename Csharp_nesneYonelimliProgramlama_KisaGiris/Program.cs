using System;

namespace Csharp_nesneYonelimliProgramlama_KisaGiris
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//bu projede, projemize bir class ekleyeceğiz

			Selamla(); //metotumuzu çağırmış olduk


			Ogrenci ogrenci = new Ogrenci(); //Örnekledik, bu örneklemeyi şuan için
											 //ilgili metota ulaşmakta kullanılan işlem olarak düşünebiliriz
			ogrenci.SelamlaOgrenci(); //classın içindeki metotu çağırdık

			ogrenci.OgrenciMetot("Miray", "Durgun");
			//ogrenci.OgrenciMetot2 private olduğundan buradan erişim sağlanamıyor

		}
		static void Selamla()
		{
			Console.WriteLine("Selam");
		}
	}
}
