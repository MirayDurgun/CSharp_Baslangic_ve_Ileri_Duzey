using System;

namespace MantiksalOperatorler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//VE operatörü &&
			//geriye bool döner
			//bool = degisken1==1 && degisken2=="abc"
			//iki değişkenin de true gelmesi lazım

			string kullanici = "miray";
			string sifre = "123";
			bool deger = kullanici == "abc" && sifre == "123";
			Console.WriteLine(deger);


			//VEYA operatörü || andle aynı şekilde tanımlanır 
			//iki değişkenden birinin true gelmesi yeterlidir

			bool deger2 = kullanici == "abc" || sifre == "123";
			Console.WriteLine(deger2);
		}
	}
}
