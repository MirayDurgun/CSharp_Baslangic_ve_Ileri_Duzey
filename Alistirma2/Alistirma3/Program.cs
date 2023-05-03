using System;

namespace Alistirma3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//kullanıcıdan gelen 3 farklı sınav notunun ortalaması
			//45 değerine eşit veya büyük mü diye kontrol ettirelim

			Console.WriteLine("1.Sınav notu");
			double s1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("2.Sınav notu");
			double s2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("3.Sınav notu");
			double s3 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Hesaplama Yapılıyor...");

			double ort = (s1 + s2 + s3) / 3;
			//kontrol ederken bool kullanılır
			bool sonuc = ort >= 45;
			Console.WriteLine("Ortalamanız 45'ten büyüktür  " + sonuc);

			bool sonuc2 = ort <= 45;
			Console.WriteLine("Ortalamanız 45'ten küçüktür  " + sonuc2);



		}
	}
}
