using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
	public sealed class Egitmen : Personel
	{
		//Egitmen : Personel miras almadır
		//bu şekilde miras alınca temel tipi örneklemeye gerek kalmasan 
		//eğitmeni örneklediğimiz parametre ile temel tipte bulunan her şeye erişebiliriz
		//program çalışırken önce kalıtıldığı yere gider
		public string Brans { get; set; }
		public int BransSeviye { get; set; }



		public Egitmen()
		{
			Console.WriteLine("Egitmen nesnesinin yapıcı metotu çalıştı");
			//IdAtamaIslemi
			//temel tipin içindeki id metoduna atadı

		}
	}
}
