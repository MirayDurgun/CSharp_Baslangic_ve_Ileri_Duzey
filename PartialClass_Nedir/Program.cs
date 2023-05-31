using System;

namespace PartialClass_Nedir
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//partial class
			//amacı kodlardaki düzeni sağlamak
			/*musteri classının içindekileri partiallamak için
			 oluşturduğumuz yeni classları partiallemek için mesela adı ogrenci_Field ise 
			 class içinde _Field kısmını silip metotlarımızı yazıyoruz


			 */

			musteri m1 = new musteri();
			m1.id = 1;
			m1.isim = "Miray";
			m1.soyisim = "Durgun";
			m1.emailAdres = "miray@gmail.com";

			int sonuc = m1.yeniKayit(m1);
			if (sonuc > 0)
			{
				Console.WriteLine("Database yeni kayıt eklendi");
			}

			ogrenci o1 = new ogrenci();
			o1.id = 1;
			o1.yeniKayit(o1);

		}
	}
}
