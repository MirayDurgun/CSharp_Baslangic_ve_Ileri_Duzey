using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Nedir
{
	public class sanalDatabase
	{
		ArrayList sanalDB = new ArrayList();
		public musteriReturnValue musteriYeniKayit(Musteri M)
		{
			sanalDB.Add(M);
			return musteriReturnValue.kayitBasarili;
		}
	}
}
