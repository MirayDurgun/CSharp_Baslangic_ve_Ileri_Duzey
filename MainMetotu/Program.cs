using System; //bir kütüphane dosyasını kütüphane içine ekleme

namespace MainMetotu
//namespace içinde class tanımlarımız bulunur
//class tanımlarımız .netframework içerisinde bulunan küçük paketlerimizdir
{
	internal class Program
	//1 classta birden çok metot bulunabilir
	//ve her motot kendisi çağrıldığında işlem yapar
	{
		static void Main(string[] args)
		{
			//system usingi olmasaydı şu şekilde yazarız;
			System.Console.WriteLine("Merhaba");
			//usingte system kütüphanesi eklemiş şekli şu şekildedir;
			Console.WriteLine("Merhaba");

			Selamla(); //metotumuzu çağırmış olduk
		}
		static void Selamla()
			//void geriye herhangi bir parametre döndürmez
			//selamla metot adı
		{
			Console.WriteLine("Selam");
		}
	}
}
