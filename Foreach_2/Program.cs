using System;

namespace Foreach_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region ornek
			//int veri tipinde 1 dizi oluşturalım,
			//kullanıcımız dizinin kaç elemanlı olacağını söylesin
			//ve dizi içindeki alanlara değer ataması yazpsın
			//Daha sonra dizi içindeki elemanların toplamlarını
			//ve ortalamasını ekrana yazdıralım

			Console.WriteLine("Lütfen dizinin kaç elamanlı olacağını belirleyiniz");
			int diziElemani = Convert.ToInt32(Console.ReadLine());
			int[] dizi = new int[diziElemani];
			for (int i = 0; i < dizi.Length; i++)
			{
				Console.WriteLine("Lütfen dizilere değer giriniz");
				Console.WriteLine("{0}. Dizi için değeriniz", i);
				dizi[i] = int.Parse(Console.ReadLine());
				//kullanıcının girdiği değeri int e çevirir
			}
			Console.WriteLine("Tebrikler dizinin içindeki tüm alanları doldurdunuz");
            Console.WriteLine("Dizi içindeki elemanların toplamı ve ortalama bilgisi aşağıda verilecektir");

			int toplam = 0, ortalama = 0;
			foreach(int item in dizi)
			{
                Console.WriteLine(item);
				toplam += item;
				ortalama= toplam / dizi.Length;
            }
            Console.WriteLine("+_____________________");
			Console.WriteLine(toplam);
            Console.WriteLine("Ortalama = " +ortalama);


            #endregion
        }
	}
}
