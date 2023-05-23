using System;
using Static_Field_Kullanim;

namespace Static_Standart_davranis_farki
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//önce static yapıcı metot çalışır

			Personel personel = new Personel();
			personel.Isim = "Miray";
			personel.Soyisim = "Durgun";
			personel.Emailadres = "miray@gmail.com";
			personel.cinsiyet = 01; //01 kadın - 02 erkek

			Personel personel2 = new Personel();
			personel2.Isim = "Miray";
			personel2.Soyisim = "Durgun";
			personel2.Emailadres = "miray@gmail.com";
			personel2.cinsiyet = 01; //01 kadın - 02 erkek


		}
	}
}
