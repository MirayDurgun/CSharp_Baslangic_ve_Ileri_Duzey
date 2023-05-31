using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Nedir
{
	public interface IMusteri
	{
		//interface içinde yapıcı metot kullanılmaz
		//bütün tanımlalrı şablondur, kuraldır.

		//interface içinde neler olur?
		//field, metot olur

		//field
		int id { get; set; }
		string isim { get; set; }
		string soyisim { get; set; }

		//metot
		int yenikayit(string isim, string soyisim);
		int kayitduzenle(int id, string isim, string soyisim);
		int kayitsil(int id);
	}
}
