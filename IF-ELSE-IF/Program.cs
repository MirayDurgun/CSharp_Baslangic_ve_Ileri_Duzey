using System;

namespace IF_ELSE_IF
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("1. sayi giriniz");
			string s1 = Console.ReadLine();
			Console.WriteLine("2. sayi giriniz");
			string s2 = Console.ReadLine();

			decimal sayi1 = Convert.ToDecimal(s1);
			decimal sayi2 = Convert.ToDecimal(s2);
			decimal toplam = sayi1 + sayi2;

			if (toplam > 50) //şartı belirler
			{
				Console.WriteLine("Toplam " + toplam + ", 50'den büyüktür");
			}
			else if (toplam == 50) //2. şartı belirler
			{
				Console.WriteLine("Toplam " + toplam + ", 50'ye eşittir"); ;
			}
			else //şartları sağlamıyorsa şunu yap demek için kullanılır
			{
				Console.WriteLine("Toplam " + toplam + ", 50'den büyük ve eşit değildir");
			}
			//else if, if ve else'nin ortasına yazılır

		}
	}
}
