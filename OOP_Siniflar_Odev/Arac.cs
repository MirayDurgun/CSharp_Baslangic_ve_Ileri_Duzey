using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Siniflar_Odev
{
	public class Arac
	{
		public string Marka;
		public string Model;
		public int ModelYil;
		public decimal KM;
		public int YakitTipi;
		public int VitesTipi;
		public decimal AlisFiyat;
		public decimal SatisFiyat;
		public decimal MaxİndTutar;
		public decimal Fiyat;
		private string v;

		public Arac()
		{

		}

		public Arac(string v)
		{
			this.v = v;
		}

		public Arac(string _marka, string _model)
		{
			Marka = _marka;
			Model = _model;
		}
		public Arac(string _marka, string _model, int _modelYil)
		{
			Marka = _marka;
			Model = _model;
			ModelYil = _modelYil;
		}
		public Arac(string _marka, string _model, int _modelYil, decimal _km)
		{
			Marka = _marka;
			Model = _model;
			ModelYil = _modelYil;
			this.KM = _km;
			/* Sınıfın alanlarıyla aynı isimde bir parametre veya yerel bir değişken tanımladığınızda,
			 * bu durumu ayırt etmek için "this" anahtar kelimesini kullanabilirsiniz.*/
		}
		public void BilgileriGoruntule()
		{
			Console.WriteLine("Marka {0}\nModel {1}\nModel Yılı {2}\nKM {3}", Marka, Model, ModelYil, KM);
		}
		public void FiyatAta(decimal _fiyat)
		{
			decimal FiyatHesap = SatisFiyat - MaxİndTutar;
			if (_fiyat < FiyatHesap)
			{
				Console.WriteLine("Geçersiz fiyat girişi");
			}
			else
			{
				this.Fiyat = _fiyat;
				Console.WriteLine("Fiyat güncellendi");
			}
		}
	}
}
