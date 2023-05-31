using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Nedir
{
	public partial class ogrenci
	//iki öğrenci classını da tek bir öğrenci classıymış gibi göstereceğiz
	//public class ogrenci içine, partial olduğunu belirtmek için partial anahtar kelimesi eklenir
	{
		public int yeniKayit(ogrenci o)
		{
			Console.WriteLine("Kayıt işlemi başarılı");
			return 1;
		}
		public int kayitGuncelle(ogrenci o)
		{
			Console.WriteLine("Kayıt güncellendi");
			return 1;
		}
		public int kayitSil(int id)
		{
			Console.WriteLine("Kayıt silindi");
			return 1;
		}
	}
}
