using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verileri_Kapsulleme_1
{
	internal class Musteri
	{
		//Class => Field
		public int id;
		public string name;
		public string surname;
		private string emailAdres;

		public string EmailAdres
		{
			get
			{
				return this.emailAdres; //private fieldinin içindeki değeri onu çağıran kişiye göster
			}
			set
			{
				//gelen değeri value ile yakalarız
				this.emailAdres = value; //yakaladığın değeri private olan email içine at
			}
		}
	}
}
