using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verileri_Kapsulleme_4
{
	internal class Musteri
	{
		public string isim;
		private string _soyisim;
		public string Soyisim
		{
			get { return this._soyisim; }
			set
			{
				this._soyisim = value;
				this.email = string.Format("{0}.{1}@hotmail.com", isim, _soyisim);
			}
		}
		private string email;
		public string EMail
		{
			get
			{
				return this.email;
			}
			private set
			{
				this.email = value;
			}
		}
	}
}
