using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_Odev
{
	public class Bilgisayar : Urun
	{
		//hem ürün hemde base_Class bilgilerine erişebilir çünkü urun classı baseyi miras aldı
		public string islemci { get; set; }
		public string ram { get; set; }
		public string ekrankarti { get; set; }
	}
}
