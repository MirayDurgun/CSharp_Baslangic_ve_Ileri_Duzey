using System;

namespace Alistirma
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//yaş hesaplama
			Console.WriteLine("Merhaba");
			Console.WriteLine("İsminiz?");
			string isim = Console.ReadLine();
			Console.WriteLine("Soyisminiz?");
			string soyisim = Console.ReadLine();
			Console.WriteLine("Dogum yılınız?");
			string dgmyili = Console.ReadLine();

			Console.Clear();
			Console.WriteLine("İsim : " + isim + "\nSoyisim : " + soyisim);

			//1. yaş hesaplama 
			int yil = Convert.ToInt32(dgmyili);
			//yaşı işlem yapacağımız için inte çevirdik
			int simdikiYil = 2023;
			int yas = simdikiYil - yil;
			Console.WriteLine("Yas : " + yas);

			//2. yaş hesaplama yılı her sene değiştirmek zorunda değiliz datetime kodu ile olabilir
			int suankiYil = DateTime.Now.Year;
			int yas1 = suankiYil - yil;
			Console.WriteLine("Yasiniz : " + yas1);


			Console.ReadLine();
		}
	}
}
