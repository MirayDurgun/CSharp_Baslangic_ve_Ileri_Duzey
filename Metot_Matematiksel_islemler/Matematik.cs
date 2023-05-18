using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Matematiksel_islemler
{
	public class Matematik
	{

		public decimal Toplamaİslemi(decimal sayi1, decimal sayi2) //geriye decimal değer döndürsün
		{
			decimal sonuc = sayi1 + sayi1;
			return sonuc; //geri değer döndürür
		}
		public decimal Cikarmaİslemi(decimal sayi1, decimal sayi2)
		{
			decimal sonuc = sayi1 - sayi1;
			return sonuc; //geri değer döndürür
		}
		public decimal Carpmaİslemi(decimal sayi1, decimal sayi2)
		{
			decimal sonuc = sayi1 * sayi1;
			return sonuc; //geri değer döndürür
		}
		public decimal Bolmeİslemi(decimal sayi1, decimal sayi2)
		{
			decimal sonuc = sayi1 / sayi1;
			return sonuc; //geri değer döndürür
		}
		public void menu()//geriye bir şey dönmeyecek sadece ekrana yazdıracak
		{
			Console.Clear();
			Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
			Console.WriteLine("Toplama için + seçiniz");
			Console.WriteLine("Çıkartma için - seçiniz");
			Console.WriteLine("Çarpma için * seçiniz");
			Console.WriteLine("Bölme için / seçiniz");
		}
		public void sonucEkranaYaz(decimal deger1, decimal deger2, decimal sonuc, string operators)
		{
			Console.WriteLine("{0} {1} {2} = {3}", deger1, operators, deger2, sonuc);
		}

		
	}
}
