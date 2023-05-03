using System;

namespace IF
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //şartımız doğruysa yapılması gereken ek işleri belirler

            Console.WriteLine("1. sayi giriniz");
			string s1=Console.ReadLine();
			Console.WriteLine("2. sayi giriniz");
			string s2 = Console.ReadLine();

			decimal sayi1=Convert.ToDecimal(s1);
			decimal sayi2=Convert.ToDecimal(s2);
			decimal toplam = sayi1 + sayi2;

			if (toplam > 50) 
			{
                Console.WriteLine("Toplam 50'den büyüktür" +toplam);
            }
		}
	}
}
