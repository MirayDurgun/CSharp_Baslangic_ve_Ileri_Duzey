using System;

namespace Alistirmalar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string kullanici = "miray";
			string sifre = "123";

			Console.WriteLine("kullanıcı adı");
			string ad = Console.ReadLine();
			Console.WriteLine("sifre");
			string parola = Console.ReadLine();

			if (kullanici == ad && sifre == parola)
			{
				Console.WriteLine("Girişiniz başarılı");
			}
			else
			{
				Console.WriteLine("hatalı giriş");
			}
		}
	}
}
