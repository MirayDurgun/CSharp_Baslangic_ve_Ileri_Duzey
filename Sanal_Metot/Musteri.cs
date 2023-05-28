using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanal_Metot_Nedir
{
	public class Musteri // normalde kalıtırken : ile kalıtırdık ama obje kalıtımında buraya object yazmıyoruz bunun yerine
						 //: Object => Framework standart olarak tüm nesneleri object den türetir. 
	{
		public int musteriID { get; set; }
		public string isim { get; set; }
		public string soyisim { get; set; }


		//override  anahtar kelimesini kullandığımızda, kullandığımız class türemiş olduğu classın içindeki 
		//tüm sanal metotları karşımıza getirir
		//buradaki override objectten türediği için, object nesnesinin sanal metotlarını getirir
		public override string ToString() //to string sanal metodunu düzeltmek istedik
		{ //metodun bosysi burası


			// return base.ToString();
			//yani kalıtılan classı gösterir
			//base dediğmizde nesnenin kalıtılmış olan nesnesine ulaşırız

			return isim + " " + soyisim;
			//ne zaman tostring metodunu çağırırsak ilgili müşterinin isim ve soyisim bilgilerini 
			//bu şekilde versin
		}

	}
}
