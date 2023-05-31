using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Nedir
{
	public class Musteri : IMusteri
	//IMusteri classını implement interface diyoruz
	{
		int _id;
		string _isim;
		string _soyisim;
		public int id
		{
			get { return _id; }
			set { _id = value; }
		}
		public string isim
		{
			get { return _isim; }
			set { _isim = value; }
		}
		public string soyisim
		{
			get { return _soyisim; }
			set { _soyisim = value; }
		}

		public int kayitduzenle(int id, string isim, string soyisim)
		{
			Console.WriteLine("kayıt düzenlendi");
			return 1;
		}

		public int kayitsil(int id)
		{
			Console.WriteLine("kayıt silindi");
			return 1;
		}

		public int yenikayit(string isim, string soyisim)
		{
			Console.WriteLine("yeni kayıt eklendi");
			return 1;
		}
	}
}
