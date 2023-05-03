using System;

namespace Odev
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("kullanıcı kodu");
			string kKod = Console.ReadLine();
			if (kKod == "ABC" || kKod == "123" || kKod == "CMK" || kKod == "236")
			{
				Console.WriteLine("giriş başarılı");
			}
			else if (kKod == "HHH" || kKod == "BBB" || kKod == "MMM")
			{
				Console.WriteLine("kullanıcı girişi kilitlenmiştir");
			}
			else
			{
				Console.WriteLine("hatalı kullanıcı kodu");
			}
		}
	}
}
