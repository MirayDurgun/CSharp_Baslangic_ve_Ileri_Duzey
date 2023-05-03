using System;

namespace IF_ELSE
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

			if (toplam > 50)
			{
				Console.WriteLine("Toplam 50'den büyüktür" + toplam);
			}
			else //şartı sağlamıyorsa şunu yap demek için kullanılır
			{
				Console.WriteLine("Toplam 50'den büyük değildir" + toplam);
			}
		}
	}
}
