using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Static_Field_Kullanim
{
	public class Personel
	{
		//Static field kullanımı
		public static string domainAdres;
		public string Isim { get; set; }
		public string Soyisim { get; set; }
		private string _emailadres;

		public string Emailadres
		{
			get { return this._emailadres; }
			set { this._emailadres = value.ToLower() + "@" + Personel.domainAdres; }
		}
		public int cinsiyet { get; set; }

		public Personel()
		{
			Console.WriteLine("Her örneklemede çalışan standart metot");

		}

		//önce static yapıcı metot çalışır

		static Personel()
		{
			domainAdres = "firmam.com";
			Console.WriteLine("Yalnızca 1 kez çalışan static metot");
		}
	}
}
