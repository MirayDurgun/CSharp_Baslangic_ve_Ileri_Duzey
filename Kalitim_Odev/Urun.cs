using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_Odev
{
	public class Urun : Base_Class
	{
		public string marka { get; set; } //belirtmiş olduğumuz markalar içinde ürün eklenebilsin
		public string model { get; set; }



		private decimal _alisFiyat;
		public decimal alisFiyat
		{ //0 dan küçük olmamamlı
			get { return _alisFiyat; }
			set
			{
				if (value <= 0)
				{ Console.WriteLine("Alış fiyatı 0dan küçük veya eşit olamaz"); }
				else { _alisFiyat = value; }
			}

		}


		private decimal _satisFiyat;
		public decimal satisFiyat
		{ //alış fiyatından küçük olmamalı
			get { return _satisFiyat; }
			set
			{
				if (value <= _alisFiyat)
				{ Console.WriteLine("Satış fiyatı, alış fiyatından küçük veya eş olamaz"); }
				else { _satisFiyat = value; }
			}
		}


		private decimal _kampanyaFiyat;
		public decimal kampanyaFiyat
		{//0dan küçük olamaz
			get { return _kampanyaFiyat; }
			set
			{
				if (value <= 0)
				{ Console.WriteLine("Alış fiyatı ve kampanya fiyatı 0'dan küçük olamaz!"); }
				else { _kampanyaFiyat = value; }
			}
		}
	}
}
