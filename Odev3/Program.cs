using System;

namespace Odev3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*kullanıcı kodu AA - BB - CC admin yetkisi
			 * kullanıcı kodu DD güçlü kullamıcı yetkisi
			 * kullanıcı kodu FF - EE - GG standart kullanıcı kodu
			 * farklı giriş olursa hatalı kullanıcı kodu
			 */

			string kullanici_kodu;
            Console.WriteLine("Kullanıcı kodları şu şekildedir:");
            Console.WriteLine("AA - BB - CC = admin yetkisi");
            Console.WriteLine("DD = güçlü kullanıcı yetkisi");
            Console.WriteLine("FF - EE - GG = standart kullanıcı yetkisi");
            Console.WriteLine("Kod giriniz");
            kullanici_kodu = Convert.ToString(Console.ReadLine());

			switch(kullanici_kodu)
			{
				case "AA":
				case "BB":
				case "CC":
                    Console.WriteLine("Sistem yöneticisi yetkisine sahipsiniz");
					break;
				case "DD":
                    Console.WriteLine("Güçlü kullanıcı yetkisine sahipsiniz");
					break;
				case "FF":
				case "EE":
				case "GG":
                    Console.WriteLine("Standart kullanıcı yetkisi");
					break;
				default:
                    Console.WriteLine("Hatalı kullanıcı kodu");
					break;
            }


        }
	}
}
