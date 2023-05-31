using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Nedir
{
	public class musteri
	{
		public int id { get; set; }
		public string isim { get; set; }
		public string soyisim { get; set; }
		public string emailAdres { get; set; }

		public int yeniKayit(musteri m)
		{
			Console.WriteLine("Database kayıt işlemi tamamlandı");
			return 1;
		}
		public int kayitGuncelle(musteri m)
		{
			Console.WriteLine("Müşteri kaydı güncellendi");
			return 1;
		}
		public int kayitSil(int id)
		{
			Console.WriteLine("Müşteri kaydı silindi");
			return 1;
		}
	}
}
