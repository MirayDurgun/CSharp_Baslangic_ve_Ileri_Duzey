using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOdev1
{
	public class Ogrenci
	{
		public void ogrenciPuanHesapla(decimal not1, decimal not2, decimal not3, decimal ortalama, string Ad, string Soyad)
		{
			Console.WriteLine("Öğrenci Bilgileri");
			Console.WriteLine("Ad Soyad : {0} {1}", Ad.ToUpper(), Soyad.ToUpper());
			Console.WriteLine("1. Not = {0}\n2. Not = {1}\n3. Not = {2}", not1, not2, not3);
			ortalama = (not1 + not2 + not3) / 3;
			if (ortalama < 45)
			{
				Console.WriteLine("Ortalama değeriniz = {0}\nKaldınız", ortalama);
			}
			else
			{
				Console.WriteLine("Ortalama değeriniz = {0}\nGeçtiniz", ortalama);
			}
		}
		public void EkranaYazdir(decimal ortalama)
		{
			Console.WriteLine("Ortalamanız = {0}", ortalama);
		}
	}
}
