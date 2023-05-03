using System;

namespace Alistirma
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//4 işlem + mod
			Console.WriteLine("1. Değeri giriniz");
			decimal sayi1 = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine("2. Değeri giriniz");
			decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

			decimal top = sayi1 + sayi2;
			decimal carp = sayi1 * sayi2;
			decimal cik = sayi1 - sayi2;
			decimal bol = sayi1 / sayi2;
			decimal mod = sayi1 % sayi2;
			Console.WriteLine("+ : " + top + "\n* : " + carp + "\n- : " + cik + "\n/ : " + bol + "\n% : " + mod);

		}
	}
}
