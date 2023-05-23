using System;
using System.ComponentModel;
using Verileri_Kapsulleme_1;

namespace Verileri_Kapsulleme_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Ornek 1 Field değer ataması yapılamasın ama değer okunsun
			Musteri m1 = new Musteri();
			Console.WriteLine(m1.ID);
			m1.ID = 2; //değer ataması yapılmasın

		}
	}
}
