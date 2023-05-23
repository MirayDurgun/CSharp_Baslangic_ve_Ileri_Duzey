using System;
using Verileri_Kapsulleme_1;

namespace Kapsulleme_Alistirma_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Kpasüllemeye giriş
			//değeri içine atayıp görüntüledik
			Musteri m1 = new Musteri();
			m1.id = 1;
			m1.name = "Miray";
			m1.surname = "Durgun";
			m1.EmailAdres = "miray@gmail.com";
		}
	}
}
