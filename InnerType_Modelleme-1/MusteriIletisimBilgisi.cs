using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType_Modelleme_1
{
	public class MusteriIletisimBilgisi
	{
		public int iletisimTip { get; set; } //01 derse mobil 02 derse sabit hat olsun
		public string alankodu { get; set; }
		public string numara { get; set; }
		public bool Aktif_Pasif { get; set; } //iletişim bilgisi güncel mi değil mi

		//Inner Type metotlara erişme ve kullanma tüm classlara yapılacak
		public void musteriIletisimTestMetot()
		{
			Console.WriteLine("Müşteri iletişim test metot");
		}
	}
}
