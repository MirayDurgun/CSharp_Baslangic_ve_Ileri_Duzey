using System;

namespace Static_Field_Kullanim
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//personel uygulaması

			Personel personel = new Personel();
			personel.Isim = "Miray";
			personel.Soyisim = "Durgun";
			personel.Emailadres = "miray@gmail.com";
			personel.cinsiyet = 01; //01 kadın - 02 erkek

			Helper.emailGonder("miray@gmail.com", "Tanışma", "Şuan C# eğitimi almaktasın" + personel.Isim + personel.Soyisim);

			//Helper_2 h2 = new Helper-2(); helper_2 static olduğundan bu classı örnekleyemeyiz


			//static yapıcı metot 1 kez çalıştı
			Helper_2.emailGonder("miray@gmail.com", "Tanışma", "Şuan C# eğitimi almaktasın" + personel.Isim + personel.Soyisim);
			Helper_2.emailGonder("miray@gmail.com", "Tanışma", "Şuan C# eğitimi almaktasın" + personel.Isim + personel.Soyisim);
		}
	}
}
