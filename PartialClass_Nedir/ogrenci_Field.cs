using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Nedir
{
	public partial class ogrenci
	//iki öğrenci classını da tek bir öğrenci classıymış gibi göstereceğiz
	{
		public int id { get; set; }
		public string isim { get; set; }
		public string soyisim { get; set; }
		public int ogrenciNumarasi { get; set; }
	}
}
