using System;

namespace Foreach3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//20 elemanlı bir int dizi oluşturalım
			//değerlerimizi random belirleyelim
			//daha sonra dizi içindeki elemanları ekrana
			//yazdıralım ve dizi içinde kaç tane 4 sayısı var onu da 
			//ekrana yazdıralım


			Random rnd = new Random();
			int[] dizi = new int[20];

			for(int i = 0; i < dizi.Length; i++)
			{
				dizi[i]= rnd.Next(1,10);
            }
			int kactaneBuldu = 0;
			foreach(int item in dizi)
			{
                Console.Write(item+", ");
                if (item == 4)
				{
					kactaneBuldu++;
				}
            }
            Console.WriteLine("\nDizi içinde değeri 4 olan {0} adettir",kactaneBuldu);
        }
	}
}
