using System;

namespace Enum_Nedir
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//ENUM
			//enum okuma kolaylığı sağlar
			/*önceden yazığımız kod yapılarını bir çok if else bulunan classları kolayca anlamamıza olanak tanır
			 yapıyı daha okunabilir yapar*/


			Musteri M1 = new Musteri();
			M1.id = 1;
			M1.musterinumara = "mN120235";
			M1.isim = "Miray";
			M1.soyisim = "Durgun";
			M1.mailAdres = "miray@gmail.com";

			sanalDatabase SB = new sanalDatabase();
			musteriReturnValue musteriKayitSonuc = SB.musteriYeniKayit(M1);

			if (musteriKayitSonuc == musteriReturnValue.kayitBasarili)
			{

			}


		}
	}
}
