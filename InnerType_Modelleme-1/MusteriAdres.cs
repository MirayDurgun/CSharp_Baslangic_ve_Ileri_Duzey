using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType_Modelleme_1
{
	public class MusteriAdres
	{
		public string adresTip { get; set; }
		public string Il { get; set; }
		public string Ilce { get; set; }
		public string Adres { get; set; }
		public MusteriAdres()
		{
			Console.WriteLine("Müşteri Adres yapıcı metodu çalıştı");
		}

		//Inner Type metotlara erişme ve kullanma tüm classlara yapılacak
		public void musteriAdresTestMetot()
		{
			Console.WriteLine("Müşteri adres test metot");
		}

	}
}
