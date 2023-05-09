using System;

namespace Odev2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*kullanıcı sayı girişi yapacak
			*girilen sayının faktöriyelini alıp ekrana yazdırma
			 */
			int sonuc = 1;
			Console.WriteLine("Lütfen faktöriyelini almak istediğiniz sayıyı giriniz");
			int sayi = Convert.ToInt32(Console.ReadLine());

			for (int i = sayi; i > 1; i--)
			{
				sonuc *= i;

			}
			Console.WriteLine("Girilen değer = {0}! hesaplanan sonuc = {1}", sayi, sonuc);
		}
	}
}
