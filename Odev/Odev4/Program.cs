using System;

namespace Odev4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Benim ayptığım for ile
			//  sistemin çalışma zamanında oluşturduğu
			//  1 - 10 arasındaki bir değeri kullanıcının
			//  tahmin etmesini isteyecek

			Random rnd = new Random();
			int sistemSayi = rnd.Next(1, 10);
			Console.WriteLine("Sistem bir sayı buldu tahmin edelim");
			Console.WriteLine("Not sadece 3 tahmin hakkınız bulunmakta");
			Console.WriteLine("1 ile 10 arasında tahmin ediniz");

			for (int sayac = 1; sayac <= 3; sayac++)
			{
				Console.WriteLine("{0}. Tahmininizi giriniz", sayac);
				int tahmin = Convert.ToInt32(Console.ReadLine());
				if (tahmin <= 0 || tahmin > 10)
				{


					Console.WriteLine("Değer dışı, 1 ve 10 arasında değer giriniz!");
					break;
				}
				else
				{
					if (tahmin == sistemSayi)
					{
						Console.WriteLine("Tebrikler sayıyı buldunuz");
						break;
					}

				}

			}
			Console.WriteLine("Sistemin tahmin ettiği sayı {0}", sistemSayi);



			/*hocanın yaptığı while ile */
			/*int tahminAdet = 1;
			Random rnd = new Random();
			int sistemSayi = rnd.Next(1, 10);
			while (true)
			{
				Console.WriteLine("{0}. Deneme - Lütfen üretmiş olduğu sayıyı tahmin ediniz : ", tahminAdet);
				string kullanıcıdanGelen = Console.ReadLine();
				int kullanıcıdanGelenInt = int.Parse(kullanıcıdanGelen); //stringi inte çevirdik
				if (kullanıcıdanGelenInt == sistemSayi)
				{
					Console.WriteLine("Tebrikler!");
					break;
				}
				else
				{	
					tahminAdet++;
					Console.WriteLine("Tahmininiz yanlış, lütfen yeniden deneyiniz...");
				}

			}*/
		}
	}
}
