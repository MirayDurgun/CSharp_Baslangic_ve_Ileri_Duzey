using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Nedir
{
	public abstract class TemelSinif
	{
		//	public sealed abstract class TemelSinif= sealed ve abstract bir arada kullanılamaz


		public DateTime kayitTarih { get; set; }
		public DateTime guncellemeTarih { get; set; }

		public TemelSinif()
		{
			kayitTarih = DateTime.Now;
			guncellemeTarih = DateTime.Now;
		}
		public void Test()
		{
			Console.WriteLine("Temel sınıf => Test metodu");
		}
		public abstract void TestAbstract();
		//new ile örneklenemez 
		//abstract metotların bodysine gerek yoktur "{}"
		//sadece metot imza yazılır
		//abstract metot veye içinde bulunan fieldler kullanılmak zorundadır
		//Musteri sinifi miras aldığı için kullanmak zorundadır aksi durumda hata verir
		//hatanın üzerine ctrl . yaparak implement ederiz

	}
}
