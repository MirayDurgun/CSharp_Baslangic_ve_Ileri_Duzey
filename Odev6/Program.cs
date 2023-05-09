using System;

namespace Odev6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* kullanıcıdan 1-x arasında sayı girmesini iste
			 * sistem, kullanıcının girmiş olduğu 1- x değerleri
			 * arasında sayı tahmini yapsın
			 * sonra kullanıcı sistemin tahmin ettiği sayıyı 
			 * bulmaya çalışsın
			 * bulamazsa yeniden sorsun
			 * ne zaman değeri bulursa y kadar denediniz
			 * ve sonuca ulaştınız desin
			 */

			int sayac = 0, tahmin;
			Console.WriteLine("Bu oyunda 1 ile kaç arasında tahmin edileceğini siz belirleyeceksiniz");
			Console.WriteLine("tahmin oyunu için en yüksek değeri giriniz");
			int maxDeger = Convert.ToInt32(Console.ReadLine());
			Random rnd = new Random();
			int deger = rnd.Next(1, maxDeger);
			do
			{
				sayac++;
				Console.WriteLine("{0}. Hakkınız üretilen sayıyı tahmin ediniz", sayac);
				tahmin = Convert.ToInt32(Console.ReadLine());
			} while (tahmin != deger);
			Console.WriteLine("{0} kere denediniz ve sayıyı tahmin ettiniz", sayac);




		}
	}
}
