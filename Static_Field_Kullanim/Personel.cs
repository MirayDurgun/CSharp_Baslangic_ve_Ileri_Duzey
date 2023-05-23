using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Field_Kullanim
{
	internal class Personel
	{
		//Static field kullanımı
		public static string domainAdres = "firmam.com";
		public string Isim { get; set; }
		public string Soyisim { get; set; }
		private string _emailadres;

		public string Emailadres
		{
			get { return this._emailadres; }
			set { this._emailadres = value.ToLower() +"@"+Personel.domainAdres; }	
		}
        public int cinsiyet { get; set; }
    }
}
