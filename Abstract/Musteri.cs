using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Nedir
{
	public class Musteri : TemelSinif
	{
		public int musteriID { get; set; }
		public Musteri()
		{
			musteriID = 1;
		}

		public override void TestAbstract() //implement ettik
		{
			Console.WriteLine("Müşteri => TestAbstract metodu");
		}
	}
}
