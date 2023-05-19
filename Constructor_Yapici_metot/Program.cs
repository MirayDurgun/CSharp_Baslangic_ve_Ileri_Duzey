using System;

namespace Constructor_Yapici_metot
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*yapıcı metot kısayolu ctor*/
			Console.WriteLine("Hello World!");

			sinif s1 = new sinif("000", "melih");//3. yapıcı metotu kullanmış olduk
			s1.ad = "Miray";
			s1.soyad = "Durgun";
			Console.WriteLine(s1.ad + "\n" + s1.soyad + "\n" + s1.tc);
			s1.tc = "0000000023"; //default değerini değiştirmiş olduk
			Console.WriteLine(s1.tc);

			bool mussteriKontrol = s1.MusteriKontrol();
		}
	}
}
