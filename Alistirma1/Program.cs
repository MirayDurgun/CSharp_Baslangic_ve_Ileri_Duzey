using System;
using System.Data;

namespace Alistirma1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Merhaba");
			Console.WriteLine("İsminiz?");
			string isim = Console.ReadLine();
			Console.WriteLine("Soyisminiz?");
			string soyisim = Console.ReadLine();
			Console.WriteLine("Sehir?");
			string sehir = Console.ReadLine();
			Console.WriteLine("Yas?");
			int yas = Convert.ToInt32(Console.ReadLine());
			//diğer türlü böyle de istenebilir
			//string yas=Console.ReadLine();
			//int yasconvert=Convert.ToInt32(yas); toint in içinde yas yazıyor readline değil

			Console.Clear();
			Console.WriteLine("İsim : " + isim + "\nSoyisim : " + soyisim);
			Console.WriteLine("Sehir : " + sehir + "\nYas : " + yas);
			



        }
	}
}
