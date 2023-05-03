using System;

namespace Switchcase
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * switch(ifade)
			 * {
			 * case kontrol1:
			 * çalışacak kodlar
			 * break; 
			 * 
			 * default: (if'teki else gibi)
			 * çalışacak olan işlemler
			 */

			Console.WriteLine("Hangi ay");
			string ay = Console.ReadLine();

			switch (ay)
			{
				case "ocak":
					Console.WriteLine("1. ay");
					break;
				case "şubat":
					Console.WriteLine("2. ay");
					break;
				case "mart":
					Console.WriteLine("3. ay");
					break;
				case "nisan":
					Console.WriteLine("4. ay");
					break;
				case "mayıs":
					Console.WriteLine("5. ay");
					break;
				case "haziran":
					Console.WriteLine("6. ay");
					break;
				case "temmuz":
					Console.WriteLine("7. ay");
					break;
				case "ağustos":
					Console.WriteLine("8. ay");
					break;
				case "eylül":
					Console.WriteLine("9. ay");
					break;
				case "ekim":
					Console.WriteLine("10. ay");
					break;
				case "kasım":
					Console.WriteLine("11. ay");
					break;
				case "aralık":
					Console.WriteLine("12. ay");
					break;
				default:
					Console.WriteLine("12 ay dışında bir değer giri yaptınız");
					break;
			}
            Console.WriteLine("Size yardımcı olamıyoruz...");
        }
	}
}
