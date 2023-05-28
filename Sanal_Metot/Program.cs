using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanal_Metot_Nedir
{
	class Program
	{
		static void Main(string[] args)
		{
			// Object => ToString();
			/*
			 * 
             * Musteri M1 = new Musteri();
             * nesneleri örneklediğimizde
             * arka tarafta müşteri nesnem object nesnesinden kalıtılıyor ve nesnem oluşuyor
             * Object => Musteri 
             *           M1.Tostring();  müşteri nesnesi içine olmayan bir metoda erişir
             *           o metotta objectin içinden kalıtım yolu ile gelir
             *           
			 * Tostring metodunu çağırınca 
			 * çağırılan classın namespace ve classın adını geri döner 
             * Namespace.Musteri 
             * 
             * 
             */

			Musteri M1 = new Musteri();
			M1.isim = "Miray";
			M1.soyisim = "Durgun";
			string toStringMesaj = M1.ToString();
			Console.WriteLine(toStringMesaj);

			// namespace Sanal_Metot.Musteri
		}
	}
}
