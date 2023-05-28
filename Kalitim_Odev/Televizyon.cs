using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_Odev
{
	public class Televizyon :Urun
	{
		//hem ürün hemde base_Class bilgilerine erişebilir çünkü urun classı baseyi miras aldı
		public bool smartTv { get; set; }
        public bool HDMI { get; set; }
        public string ekranBoyutu { get; set; }

    }
}
