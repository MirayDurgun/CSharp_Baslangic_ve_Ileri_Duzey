using System;

namespace Dizi1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] ogrenciListesi = new string[5];
			ogrenciListesi[0] = "Ceren";
			ogrenciListesi[1] = "Cemre";
			ogrenciListesi[2] = "Can";
			ogrenciListesi[3] = "Cem";
			ogrenciListesi[4] = "Ceyda";
			//Console.WriteLine(ogrenciListesi[2]);

			//oluşturduğumuz dizi elemanlarını ekrana yazdıralım
			foreach(string item in ogrenciListesi)
			{
				Console.WriteLine(item);
				//dizinin içindeki tüm elemanları yazdırır
			}
			//aynı işlemi for döngüsü ile yapalım
			for(int i=0; i<ogrenciListesi.Length; i++)
			{
				string gelenİsim = ogrenciListesi[i];
                Console.Write(gelenİsim +", ");
            }
        }
	}
}
