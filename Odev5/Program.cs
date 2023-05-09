using System;
using System.Collections.Specialized;

namespace Odev5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*kullanıcıyı do while içine alıp 
			 * kullanıcı adı ve password sor
			 * kullanıcı adı demo
			 * şifre de demo olsun
			 * kullanıcı bu değerleri bilirse
			 * döngüden çık ve başarılı yaz
			 * yanlış giriyorsa tekrardan sor
			 */
			string ad, sifre;
			do
			{
                Console.WriteLine("Kullanıcı adınızı giriniz");
			 ad = Console.ReadLine();
				Console.WriteLine("Şifre giriniz");
				 sifre = Console.ReadLine();

            } while (ad.ToLower()!="demo" || sifre.ToLower()!="demo");
			//demo Demo DeMo ... yazsa tolower değişkenin içindeki değerleri küçük yapar
			//toupper değişkenin içindeki değerleri büyük yapar
			Console.WriteLine("Başarılı");


		}
	}
}
