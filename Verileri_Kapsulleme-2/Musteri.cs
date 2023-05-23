using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verileri_Kapsulleme_1
{
	internal class Musteri
	{
		//Ornek 1 Field değer ataması yapılamasın ama değer okunsun

		public Musteri()
		{
			//nesne örneklendiğinde bir metot yardımı ile bir değer üret
			//ürettiğin değeri içerde private olarak duran
			//field içine ata
			this.id = IDUret();

		}

		private int id; //erişim belirleyicisi yazmazsak default olaral private alınır
		public string name;
		public string surname;
        public int ID
		{
			get { return this.id; }
			private set { this.id = value; } //seti private yaparsak değer atamaz
		}
		private int IDUret() //id değerini random üretir ve private fieldin içine atar
		{
			Random rnd = new Random();
			return rnd.Next(1, 100000);
		}
	}
}
