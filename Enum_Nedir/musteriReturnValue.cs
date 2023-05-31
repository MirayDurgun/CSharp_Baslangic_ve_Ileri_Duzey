using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Nedir
{
	public enum musteriReturnValue
	{
		/*Enum (Numaralandırma) ise OOP'de sıkça kullanılan bir veri türüdür.
        Enum, belirli bir veri kümesini temsil eden ve sabit değerlerin
        birer sembolik adlandırmayla ilişkilendirildiği bir liste gibi düşünülebilir.
        Bu sembolik adlar, programdaki kodun okunabilirliğini
        artırmak ve hata yapma olasılığını azaltmak için kullanılır.*/


		kayitBasarili,
		kayitBasarisiz,
		varolanMusteri,
		parametreHatasi,
		calisamaz
	}
}
